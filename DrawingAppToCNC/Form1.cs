using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace DrawingAppToCNC
{
    public partial class Form1 : Form
    {
        private Button[] openButtons;
        private Button[] writeButtons;
        private PictureBox[] picBoxes;
        private string[] gcodes = new string[4] {"", "", "", ""};
        private StreamReader sr;
        private bool streaming = false;
        public Form1()
        {
            InitializeComponent();
            openButtons = new Button[4] { OpenButton1, OpenButton2, OpenButton3, OpenButton4 };
            writeButtons = new Button[4] { WriteButton1, WriteButton2, WriteButton3, WriteButton4 };
            picBoxes = new PictureBox[4] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
        }
        private void resetUI()
        {
            for(int i = 0; i < 4; i++)
            {
                picBoxes[i].Enabled = false;
                openButtons[i].Enabled = false;
                writeButtons[i].Enabled = false;
            }
            resetButton.Enabled = false;
            comboBox.Enabled = true;
        }
        private void setUI()
        {
            for(int i = 0; i < 4; i++)
            {
                openButtons[i].Enabled = true;
                if (gcodes[i] != "")
                {
                    picBoxes[i].Enabled = true;
                    writeButtons[i].Enabled = true;
                }
                else
                {
                    picBoxes[i].Enabled = false;
                    writeButtons[i].Enabled = false;
                }
            }
            resetButton.Enabled = true;
            comboBox.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            resetUI();
            string[] ports = SerialPort.GetPortNames();
            comboBox.Items.AddRange(ports);
        }

        private void OpenPortButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                streaming = false;
                serialPort1.Close();
                OpenPortButton.Text = "Connect";
                resetUI();
            }
            else
            {
                if (comboBox.SelectedItem != null)
                {
                    try
                    {
                        serialPort1.PortName = comboBox.SelectedItem.ToString();
                        serialPort1.Open();
                        OpenPortButton.Text = "disConnect";
                        setUI();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("COMポートを選択してください！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void OpenFile(object sender, EventArgs e)
        {
            int controlIdx = 0;
            for(int i = 0; i < openButtons.Length; i++)
            {
                if (((Button)sender).Name == openButtons[i].Name)
                    controlIdx = i;
            }
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                gcodes[controlIdx] = openFileDialog1.FileName;
                string fileName = Path.GetFileNameWithoutExtension(gcodes[controlIdx]);
                string dirName = Path.GetDirectoryName(gcodes[controlIdx]);
                string[] files = Directory.GetFiles(dirName, "*");
                foreach(string file in files)
                {
                    string ext = Path.GetExtension(file);
                    if(Regex.IsMatch(ext, ".(jpg|png|bmp|gif)"))
                    {
                        if (Path.GetFileNameWithoutExtension(file) == fileName)
                        {
                            picBoxes[controlIdx].Image = System.Drawing.Image.FromFile(file);
                            break;
                        }
                    }
                    writeButtons[controlIdx].Enabled = true;
                }
            }
        }
        private void sendSerial()
        {
            if (sr == null)
                return;
            if (sr.Peek() == -1)
            {
                this.Invoke(new Action(this.setUI));
                sr.Close();
                streaming = false;
                return;
            }
            string data = sr.ReadLine();
            if (data == "")
            {
                if (sr.Peek() != -1)
                {
                    data = sr.ReadLine();
                }
                else
                {
                    this.Invoke(new Action(this.setUI));
                    sr.Close();
                    streaming = false;
                    return;
                }
            }
            serialPort1.Write(data + "\n");
        }
        private void writeFile(object sender, EventArgs e)
        {
            int controlIdx = 0;
            for (int i = 0; i < writeButtons.Length; i++)
            {
                if (((Button)sender).Name == writeButtons[i].Name)
                    controlIdx = i;
            }
            sr = new StreamReader(gcodes[controlIdx], Encoding.GetEncoding("UTF-8"));
            resetUI();
            streaming = true;
            sendSerial();
        }
        private void receiveUart(object sender, SerialDataReceivedEventArgs e)
        {
            if (streaming)
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();
                if (indata.StartsWith("ok") || indata.StartsWith("error"))
                    sendSerial();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            streaming = false;
            serialPort1.Write("G90\nG20\nG00 X0.000 Y0.000 Z0.000\n");
        }
    }
}