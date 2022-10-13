namespace DrawingAppToCNC
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WriteButton3 = new System.Windows.Forms.Button();
            this.OpenButton3 = new System.Windows.Forms.Button();
            this.OpenPortButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.WriteButton4 = new System.Windows.Forms.Button();
            this.OpenButton4 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.WriteButton2 = new System.Windows.Forms.Button();
            this.OpenButton2 = new System.Windows.Forms.Button();
            this.WriteButton1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OpenButton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.WriteButton3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.OpenButton3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.OpenPortButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WriteButton4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.OpenButton4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.WriteButton2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.OpenButton2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.WriteButton1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenButton1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WriteButton3
            // 
            this.WriteButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriteButton3.Location = new System.Drawing.Point(198, 408);
            this.WriteButton3.Margin = new System.Windows.Forms.Padding(4);
            this.WriteButton3.Name = "WriteButton3";
            this.WriteButton3.Size = new System.Drawing.Size(186, 39);
            this.WriteButton3.TabIndex = 11;
            this.WriteButton3.Text = "書き込む";
            this.WriteButton3.UseVisualStyleBackColor = true;
            this.WriteButton3.Click += new System.EventHandler(this.writeFile);
            // 
            // OpenButton3
            // 
            this.OpenButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton3.Location = new System.Drawing.Point(4, 408);
            this.OpenButton3.Margin = new System.Windows.Forms.Padding(4);
            this.OpenButton3.Name = "OpenButton3";
            this.OpenButton3.Size = new System.Drawing.Size(186, 39);
            this.OpenButton3.TabIndex = 10;
            this.OpenButton3.Text = "開く...";
            this.OpenButton3.UseVisualStyleBackColor = true;
            this.OpenButton3.Click += new System.EventHandler(this.OpenFile);
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpenPortButton.Location = new System.Drawing.Point(586, 15);
            this.OpenPortButton.Margin = new System.Windows.Forms.Padding(4);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(189, 26);
            this.OpenPortButton.TabIndex = 1;
            this.OpenPortButton.Text = "Connect";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.OpenPortButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(4, 4);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(186, 37);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // WriteButton4
            // 
            this.WriteButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriteButton4.Location = new System.Drawing.Point(586, 408);
            this.WriteButton4.Margin = new System.Windows.Forms.Padding(4);
            this.WriteButton4.Name = "WriteButton4";
            this.WriteButton4.Size = new System.Drawing.Size(189, 39);
            this.WriteButton4.TabIndex = 7;
            this.WriteButton4.Text = "書き込む";
            this.WriteButton4.UseVisualStyleBackColor = true;
            this.WriteButton4.Click += new System.EventHandler(this.writeFile);
            // 
            // OpenButton4
            // 
            this.OpenButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton4.Location = new System.Drawing.Point(392, 408);
            this.OpenButton4.Margin = new System.Windows.Forms.Padding(4);
            this.OpenButton4.Name = "OpenButton4";
            this.OpenButton4.Size = new System.Drawing.Size(186, 39);
            this.OpenButton4.TabIndex = 6;
            this.OpenButton4.Text = "開く...";
            this.OpenButton4.UseVisualStyleBackColor = true;
            this.OpenButton4.Click += new System.EventHandler(this.OpenFile);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox4, 2);
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(392, 251);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(383, 149);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox3, 2);
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(4, 251);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(380, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // WriteButton2
            // 
            this.WriteButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriteButton2.Location = new System.Drawing.Point(586, 206);
            this.WriteButton2.Margin = new System.Windows.Forms.Padding(4);
            this.WriteButton2.Name = "WriteButton2";
            this.WriteButton2.Size = new System.Drawing.Size(189, 37);
            this.WriteButton2.TabIndex = 5;
            this.WriteButton2.Text = "書き込む";
            this.WriteButton2.UseVisualStyleBackColor = true;
            this.WriteButton2.Click += new System.EventHandler(this.writeFile);
            // 
            // OpenButton2
            // 
            this.OpenButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton2.Location = new System.Drawing.Point(392, 206);
            this.OpenButton2.Margin = new System.Windows.Forms.Padding(4);
            this.OpenButton2.Name = "OpenButton2";
            this.OpenButton2.Size = new System.Drawing.Size(186, 37);
            this.OpenButton2.TabIndex = 4;
            this.OpenButton2.Text = "開く...";
            this.OpenButton2.UseVisualStyleBackColor = true;
            this.OpenButton2.Click += new System.EventHandler(this.OpenFile);
            // 
            // WriteButton1
            // 
            this.WriteButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriteButton1.Location = new System.Drawing.Point(198, 206);
            this.WriteButton1.Margin = new System.Windows.Forms.Padding(4);
            this.WriteButton1.Name = "WriteButton1";
            this.WriteButton1.Size = new System.Drawing.Size(186, 37);
            this.WriteButton1.TabIndex = 3;
            this.WriteButton1.Text = "書き込む";
            this.WriteButton1.UseVisualStyleBackColor = true;
            this.WriteButton1.Click += new System.EventHandler(this.writeFile);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox2, 2);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(392, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // OpenButton1
            // 
            this.OpenButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton1.Location = new System.Drawing.Point(4, 206);
            this.OpenButton1.Margin = new System.Windows.Forms.Padding(4);
            this.OpenButton1.Name = "OpenButton1";
            this.OpenButton1.Size = new System.Drawing.Size(186, 37);
            this.OpenButton1.TabIndex = 2;
            this.OpenButton1.Text = "開く...";
            this.OpenButton1.UseVisualStyleBackColor = true;
            this.OpenButton1.Click += new System.EventHandler(this.OpenFile);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox, 2);
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(198, 18);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(380, 23);
            this.comboBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "gcode files|*.gcode";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.receiveUart);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DrawingApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button WriteButton4;
        private System.Windows.Forms.Button OpenButton4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button WriteButton2;
        private System.Windows.Forms.Button OpenButton2;
        private System.Windows.Forms.Button WriteButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button OpenButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button OpenPortButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button WriteButton3;
        private System.Windows.Forms.Button OpenButton3;
    }
}

