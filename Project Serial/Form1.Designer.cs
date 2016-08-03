namespace Project_Serial
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.groupSerialPort = new System.Windows.Forms.GroupBox();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            this.groupMovementParameters = new System.Windows.Forms.GroupBox();
            this.textBoxAccelerationZ = new System.Windows.Forms.TextBox();
            this.textBoxVelocityZ = new System.Windows.Forms.TextBox();
            this.textBoxPreCoorZ = new System.Windows.Forms.TextBox();
            this.textBoxNextCoorZ = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAccelerationY = new System.Windows.Forms.TextBox();
            this.textBoxVelocitY = new System.Windows.Forms.TextBox();
            this.textBoxPreCoorY = new System.Windows.Forms.TextBox();
            this.textBoxNextCoorY = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAccelerationX = new System.Windows.Forms.TextBox();
            this.textBoxVelocityX = new System.Windows.Forms.TextBox();
            this.textBoxPreCoorX = new System.Windows.Forms.TextBox();
            this.textBoxNextCoorX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControlCommand = new System.Windows.Forms.GroupBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupSerialPort.SuspendLayout();
            this.groupMovementParameters.SuspendLayout();
            this.groupControlCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port name:";
            // 
            // comboPortName
            // 
            this.comboPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Location = new System.Drawing.Point(86, 24);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(99, 20);
            this.comboPortName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baudrate:";
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "76800"});
            this.comboBaudrate.Location = new System.Drawing.Point(86, 67);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(99, 20);
            this.comboBaudrate.TabIndex = 1;
            // 
            // groupSerialPort
            // 
            this.groupSerialPort.Controls.Add(this.buttonOpenClose);
            this.groupSerialPort.Controls.Add(this.label1);
            this.groupSerialPort.Controls.Add(this.comboBaudrate);
            this.groupSerialPort.Controls.Add(this.comboPortName);
            this.groupSerialPort.Controls.Add(this.label2);
            this.groupSerialPort.Location = new System.Drawing.Point(319, 12);
            this.groupSerialPort.Name = "groupSerialPort";
            this.groupSerialPort.Size = new System.Drawing.Size(200, 133);
            this.groupSerialPort.TabIndex = 2;
            this.groupSerialPort.TabStop = false;
            this.groupSerialPort.Text = "Serial Port";
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.Location = new System.Drawing.Point(53, 104);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenClose.TabIndex = 2;
            this.buttonOpenClose.Text = "Open";
            this.buttonOpenClose.UseVisualStyleBackColor = true;
            this.buttonOpenClose.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // groupMovementParameters
            // 
            this.groupMovementParameters.Controls.Add(this.textBoxAccelerationZ);
            this.groupMovementParameters.Controls.Add(this.textBoxVelocityZ);
            this.groupMovementParameters.Controls.Add(this.textBoxPreCoorZ);
            this.groupMovementParameters.Controls.Add(this.textBoxNextCoorZ);
            this.groupMovementParameters.Controls.Add(this.label18);
            this.groupMovementParameters.Controls.Add(this.label14);
            this.groupMovementParameters.Controls.Add(this.label10);
            this.groupMovementParameters.Controls.Add(this.label6);
            this.groupMovementParameters.Controls.Add(this.textBoxAccelerationY);
            this.groupMovementParameters.Controls.Add(this.textBoxVelocitY);
            this.groupMovementParameters.Controls.Add(this.textBoxPreCoorY);
            this.groupMovementParameters.Controls.Add(this.textBoxNextCoorY);
            this.groupMovementParameters.Controls.Add(this.label17);
            this.groupMovementParameters.Controls.Add(this.label13);
            this.groupMovementParameters.Controls.Add(this.label9);
            this.groupMovementParameters.Controls.Add(this.label5);
            this.groupMovementParameters.Controls.Add(this.textBoxAccelerationX);
            this.groupMovementParameters.Controls.Add(this.textBoxVelocityX);
            this.groupMovementParameters.Controls.Add(this.textBoxPreCoorX);
            this.groupMovementParameters.Controls.Add(this.textBoxNextCoorX);
            this.groupMovementParameters.Controls.Add(this.label16);
            this.groupMovementParameters.Controls.Add(this.label12);
            this.groupMovementParameters.Controls.Add(this.label8);
            this.groupMovementParameters.Controls.Add(this.label15);
            this.groupMovementParameters.Controls.Add(this.label4);
            this.groupMovementParameters.Controls.Add(this.label11);
            this.groupMovementParameters.Controls.Add(this.label7);
            this.groupMovementParameters.Controls.Add(this.label3);
            this.groupMovementParameters.Location = new System.Drawing.Point(12, 151);
            this.groupMovementParameters.Name = "groupMovementParameters";
            this.groupMovementParameters.Size = new System.Drawing.Size(507, 147);
            this.groupMovementParameters.TabIndex = 3;
            this.groupMovementParameters.TabStop = false;
            this.groupMovementParameters.Text = "Movement Parameters";
            // 
            // textBoxAccelerationZ
            // 
            this.textBoxAccelerationZ.Location = new System.Drawing.Point(392, 108);
            this.textBoxAccelerationZ.Name = "textBoxAccelerationZ";
            this.textBoxAccelerationZ.Size = new System.Drawing.Size(87, 21);
            this.textBoxAccelerationZ.TabIndex = 6;
            // 
            // textBoxVelocityZ
            // 
            this.textBoxVelocityZ.Location = new System.Drawing.Point(392, 78);
            this.textBoxVelocityZ.Name = "textBoxVelocityZ";
            this.textBoxVelocityZ.Size = new System.Drawing.Size(87, 21);
            this.textBoxVelocityZ.TabIndex = 6;
            // 
            // textBoxPreCoorZ
            // 
            this.textBoxPreCoorZ.Location = new System.Drawing.Point(392, 49);
            this.textBoxPreCoorZ.Name = "textBoxPreCoorZ";
            this.textBoxPreCoorZ.Size = new System.Drawing.Size(87, 21);
            this.textBoxPreCoorZ.TabIndex = 6;
            // 
            // textBoxNextCoorZ
            // 
            this.textBoxNextCoorZ.Location = new System.Drawing.Point(392, 18);
            this.textBoxNextCoorZ.Name = "textBoxNextCoorZ";
            this.textBoxNextCoorZ.Size = new System.Drawing.Size(87, 21);
            this.textBoxNextCoorZ.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(366, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "z:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(366, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "z:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(366, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(366, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "z:";
            // 
            // textBoxAccelerationY
            // 
            this.textBoxAccelerationY.Location = new System.Drawing.Point(273, 108);
            this.textBoxAccelerationY.Name = "textBoxAccelerationY";
            this.textBoxAccelerationY.Size = new System.Drawing.Size(87, 21);
            this.textBoxAccelerationY.TabIndex = 6;
            // 
            // textBoxVelocitY
            // 
            this.textBoxVelocitY.Location = new System.Drawing.Point(273, 78);
            this.textBoxVelocitY.Name = "textBoxVelocitY";
            this.textBoxVelocitY.Size = new System.Drawing.Size(87, 21);
            this.textBoxVelocitY.TabIndex = 6;
            // 
            // textBoxPreCoorY
            // 
            this.textBoxPreCoorY.Location = new System.Drawing.Point(273, 49);
            this.textBoxPreCoorY.Name = "textBoxPreCoorY";
            this.textBoxPreCoorY.Size = new System.Drawing.Size(87, 21);
            this.textBoxPreCoorY.TabIndex = 6;
            // 
            // textBoxNextCoorY
            // 
            this.textBoxNextCoorY.Location = new System.Drawing.Point(273, 18);
            this.textBoxNextCoorY.Name = "textBoxNextCoorY";
            this.textBoxNextCoorY.Size = new System.Drawing.Size(87, 21);
            this.textBoxNextCoorY.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(250, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "y:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(250, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(250, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(250, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "y:";
            // 
            // textBoxAccelerationX
            // 
            this.textBoxAccelerationX.Location = new System.Drawing.Point(160, 109);
            this.textBoxAccelerationX.Name = "textBoxAccelerationX";
            this.textBoxAccelerationX.Size = new System.Drawing.Size(87, 21);
            this.textBoxAccelerationX.TabIndex = 6;
            // 
            // textBoxVelocityX
            // 
            this.textBoxVelocityX.Location = new System.Drawing.Point(160, 79);
            this.textBoxVelocityX.Name = "textBoxVelocityX";
            this.textBoxVelocityX.Size = new System.Drawing.Size(87, 21);
            this.textBoxVelocityX.TabIndex = 6;
            // 
            // textBoxPreCoorX
            // 
            this.textBoxPreCoorX.Location = new System.Drawing.Point(160, 50);
            this.textBoxPreCoorX.Name = "textBoxPreCoorX";
            this.textBoxPreCoorX.Size = new System.Drawing.Size(87, 21);
            this.textBoxPreCoorX.TabIndex = 6;
            // 
            // textBoxNextCoorX
            // 
            this.textBoxNextCoorX.Location = new System.Drawing.Point(160, 19);
            this.textBoxNextCoorX.Name = "textBoxNextCoorX";
            this.textBoxNextCoorX.Size = new System.Drawing.Size(87, 21);
            this.textBoxNextCoorX.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(136, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "x:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(136, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "x:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(136, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "x:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "Acceleration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(136, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "x:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Velocity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Present Coordinate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Next Coordinate:";
            // 
            // groupControlCommand
            // 
            this.groupControlCommand.Controls.Add(this.buttonQuit);
            this.groupControlCommand.Controls.Add(this.buttonReset);
            this.groupControlCommand.Controls.Add(this.comboMode);
            this.groupControlCommand.Controls.Add(this.label19);
            this.groupControlCommand.Controls.Add(this.buttonSend);
            this.groupControlCommand.Location = new System.Drawing.Point(12, 12);
            this.groupControlCommand.Name = "groupControlCommand";
            this.groupControlCommand.Size = new System.Drawing.Size(292, 133);
            this.groupControlCommand.TabIndex = 4;
            this.groupControlCommand.TabStop = false;
            this.groupControlCommand.Text = "Control Command";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(191, 82);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(22, 82);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboMode
            // 
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboMode.Location = new System.Drawing.Point(67, 29);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(93, 20);
            this.comboMode.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "Mode:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(199, 27);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 311);
            this.Controls.Add(this.groupControlCommand);
            this.Controls.Add(this.groupMovementParameters);
            this.Controls.Add(this.groupSerialPort);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Upper   Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupSerialPort.ResumeLayout(false);
            this.groupSerialPort.PerformLayout();
            this.groupMovementParameters.ResumeLayout(false);
            this.groupMovementParameters.PerformLayout();
            this.groupControlCommand.ResumeLayout(false);
            this.groupControlCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.GroupBox groupSerialPort;
        private System.Windows.Forms.Button buttonOpenClose;
        private System.Windows.Forms.GroupBox groupMovementParameters;
        private System.Windows.Forms.TextBox textBoxAccelerationZ;
        private System.Windows.Forms.TextBox textBoxVelocityZ;
        private System.Windows.Forms.TextBox textBoxPreCoorZ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAccelerationY;
        private System.Windows.Forms.TextBox textBoxVelocitY;
        private System.Windows.Forms.TextBox textBoxPreCoorY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAccelerationX;
        private System.Windows.Forms.TextBox textBoxVelocityX;
        private System.Windows.Forms.TextBox textBoxPreCoorX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupControlCommand;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.TextBox textBoxNextCoorZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNextCoorY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNextCoorX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonQuit;
    }
}

