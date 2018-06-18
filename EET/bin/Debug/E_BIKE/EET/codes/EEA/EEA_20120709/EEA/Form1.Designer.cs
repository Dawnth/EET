namespace EEA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Key_First = new System.Windows.Forms.TextBox();
            this.textBox_Key_Second = new System.Windows.Forms.TextBox();
            this.textBox_Key_Third = new System.Windows.Forms.TextBox();
            this.textBox_Key_Fourth = new System.Windows.Forms.TextBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Generate = new System.Windows.Forms.Button();
            this.textBox_SoftwareVersion = new System.Windows.Forms.TextBox();
            this.EEA_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EEA_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_HardwareVersion = new System.Windows.Forms.TextBox();
            this.textBox_ProductModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.button_SaveFloder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_SpeedLimitVoltageDivideCoefficient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Key_First
            // 
            this.textBox_Key_First.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Key_First.Location = new System.Drawing.Point(284, 146);
            this.textBox_Key_First.MaximumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_First.MaxLength = 2;
            this.textBox_Key_First.MinimumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_First.Name = "textBox_Key_First";
            this.textBox_Key_First.Size = new System.Drawing.Size(38, 21);
            this.textBox_Key_First.TabIndex = 0;
            this.textBox_Key_First.Text = "8B";
            this.textBox_Key_First.TextChanged += new System.EventHandler(this.textBox_Key_First_TextChanged);
            // 
            // textBox_Key_Second
            // 
            this.textBox_Key_Second.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Key_Second.Location = new System.Drawing.Point(203, 146);
            this.textBox_Key_Second.MaximumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_Second.MaxLength = 2;
            this.textBox_Key_Second.MinimumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_Second.Name = "textBox_Key_Second";
            this.textBox_Key_Second.Size = new System.Drawing.Size(38, 21);
            this.textBox_Key_Second.TabIndex = 1;
            this.textBox_Key_Second.Text = "A1";
            this.textBox_Key_Second.TextChanged += new System.EventHandler(this.textBox_Key_Second_TextChanged);
            // 
            // textBox_Key_Third
            // 
            this.textBox_Key_Third.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Key_Third.Location = new System.Drawing.Point(122, 146);
            this.textBox_Key_Third.MaximumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_Third.MaxLength = 2;
            this.textBox_Key_Third.MinimumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_Third.Name = "textBox_Key_Third";
            this.textBox_Key_Third.Size = new System.Drawing.Size(38, 21);
            this.textBox_Key_Third.TabIndex = 2;
            this.textBox_Key_Third.Text = "F4";
            this.textBox_Key_Third.TextChanged += new System.EventHandler(this.textBox_Key_Third_TextChanged);
            // 
            // textBox_Key_Fourth
            // 
            this.textBox_Key_Fourth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Key_Fourth.Location = new System.Drawing.Point(41, 146);
            this.textBox_Key_Fourth.MaximumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_Fourth.MaxLength = 2;
            this.textBox_Key_Fourth.MinimumSize = new System.Drawing.Size(38, 21);
            this.textBox_Key_Fourth.Name = "textBox_Key_Fourth";
            this.textBox_Key_Fourth.Size = new System.Drawing.Size(38, 21);
            this.textBox_Key_Fourth.TabIndex = 3;
            this.textBox_Key_Fourth.Text = "56";
            this.textBox_Key_Fourth.TextChanged += new System.EventHandler(this.textBox_Key_Fourth_TextChanged);
            // 
            // button_Reset
            // 
            this.button_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Reset.Location = new System.Drawing.Point(336, 144);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(50, 23);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "重置";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Generate
            // 
            this.button_Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Generate.Enabled = false;
            this.button_Generate.Location = new System.Drawing.Point(392, 144);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(50, 23);
            this.button_Generate.TabIndex = 4;
            this.button_Generate.Text = "生成";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // textBox_SoftwareVersion
            // 
            this.textBox_SoftwareVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_SoftwareVersion.Location = new System.Drawing.Point(77, 90);
            this.textBox_SoftwareVersion.Name = "textBox_SoftwareVersion";
            this.textBox_SoftwareVersion.ReadOnly = true;
            this.textBox_SoftwareVersion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SoftwareVersion.Size = new System.Drawing.Size(45, 21);
            this.textBox_SoftwareVersion.TabIndex = 3;
            // 
            // EEA_openFileDialog
            // 
            this.EEA_openFileDialog.Filter = "CDS文件(*.cds)|*.cds";
            this.EEA_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.EEA_openFileDialog_FileOk);
            // 
            // EEA_saveFileDialog
            // 
            this.EEA_saveFileDialog.Filter = "BIN文件(*.bin)|*.bin";
            this.EEA_saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.EEA_saveFileDialog_FileOk);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(12, 12);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 4;
            this.button_Open.Text = "加载";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(284, 12);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "保存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key3";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key4";
            // 
            // textBox_HardwareVersion
            // 
            this.textBox_HardwareVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_HardwareVersion.Location = new System.Drawing.Point(239, 90);
            this.textBox_HardwareVersion.Name = "textBox_HardwareVersion";
            this.textBox_HardwareVersion.ReadOnly = true;
            this.textBox_HardwareVersion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_HardwareVersion.Size = new System.Drawing.Size(45, 21);
            this.textBox_HardwareVersion.TabIndex = 3;
            // 
            // textBox_ProductModel
            // 
            this.textBox_ProductModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ProductModel.Location = new System.Drawing.Point(392, 90);
            this.textBox_ProductModel.Name = "textBox_ProductModel";
            this.textBox_ProductModel.ReadOnly = true;
            this.textBox_ProductModel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ProductModel.Size = new System.Drawing.Size(45, 21);
            this.textBox_ProductModel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "软件版本号";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "硬件版本号";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "产品型号";
            // 
            // textBox_Date
            // 
            this.textBox_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Date.Location = new System.Drawing.Point(77, 119);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.ReadOnly = true;
            this.textBox_Date.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Date.Size = new System.Drawing.Size(162, 21);
            this.textBox_Date.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "文档日期";
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FileName.Location = new System.Drawing.Point(77, 46);
            this.textBox_FileName.Multiline = true;
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.ReadOnly = true;
            this.textBox_FileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_FileName.Size = new System.Drawing.Size(365, 38);
            this.textBox_FileName.TabIndex = 10;
            // 
            // button_SaveFloder
            // 
            this.button_SaveFloder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveFloder.Location = new System.Drawing.Point(365, 12);
            this.button_SaveFloder.Name = "button_SaveFloder";
            this.button_SaveFloder.Size = new System.Drawing.Size(77, 23);
            this.button_SaveFloder.TabIndex = 4;
            this.button_SaveFloder.Text = "打开文件夹";
            this.button_SaveFloder.UseVisualStyleBackColor = true;
            this.button_SaveFloder.Click += new System.EventHandler(this.button_SaveFloder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "加载的文档\r\n   路径";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "限速线分压系数";
            // 
            // textBox_SpeedLimitVoltageDivideCoefficient
            // 
            this.textBox_SpeedLimitVoltageDivideCoefficient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SpeedLimitVoltageDivideCoefficient.Enabled = false;
            this.textBox_SpeedLimitVoltageDivideCoefficient.Location = new System.Drawing.Point(392, 119);
            this.textBox_SpeedLimitVoltageDivideCoefficient.Name = "textBox_SpeedLimitVoltageDivideCoefficient";
            this.textBox_SpeedLimitVoltageDivideCoefficient.Size = new System.Drawing.Size(45, 21);
            this.textBox_SpeedLimitVoltageDivideCoefficient.TabIndex = 13;
            this.textBox_SpeedLimitVoltageDivideCoefficient.Text = "1.7";
            this.textBox_SpeedLimitVoltageDivideCoefficient.Leave += new System.EventHandler(this.textBox_SpeedLimitVoltageDivideCoefficient_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 182);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_SpeedLimitVoltageDivideCoefficient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SaveFloder);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.textBox_ProductModel);
            this.Controls.Add(this.textBox_HardwareVersion);
            this.Controls.Add(this.textBox_SoftwareVersion);
            this.Controls.Add(this.textBox_Key_Fourth);
            this.Controls.Add(this.textBox_Key_Third);
            this.Controls.Add(this.textBox_Key_Second);
            this.Controls.Add(this.textBox_Key_First);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(462, 216);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EEA-ECOVI Encryption Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBox_Key_First;
        internal System.Windows.Forms.TextBox textBox_Key_Second;
        internal System.Windows.Forms.TextBox textBox_Key_Third;
        internal System.Windows.Forms.TextBox textBox_Key_Fourth;
        internal System.Windows.Forms.Button button_Reset;
        internal System.Windows.Forms.Button button_Generate;
        internal System.Windows.Forms.TextBox textBox_SoftwareVersion;
        internal System.Windows.Forms.OpenFileDialog EEA_openFileDialog;
        internal System.Windows.Forms.SaveFileDialog EEA_saveFileDialog;
        internal System.Windows.Forms.Button button_Open;
        internal System.Windows.Forms.Button button_Save;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox textBox_HardwareVersion;
        internal System.Windows.Forms.TextBox textBox_ProductModel;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox textBox_Date;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox textBox_FileName;
        internal System.Windows.Forms.Button button_SaveFloder;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_SpeedLimitVoltageDivideCoefficient;

    }
}

