namespace EET
{
    partial class HelpFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpFile));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("从文件加载配置");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("保存配置到文件");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("打开文件夹");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("退出");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("文件", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("从控制器读取配置");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("下载配置到控制器");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("置顶");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("操作", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("端口");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("帮助文档");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("关于");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("帮助", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("菜单栏", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("状态栏");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("主界面", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("软件版本号");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("硬件版本号");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("产品型号");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("电机极数");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("共阴共阳");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("控制器保护温度");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("显示区", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("电机相序");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("电池额定电压");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("电池保护电压 过压");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("电池保护电压 欠压");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("霍尔");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("防飞车保护电压 上限");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("防飞车保护电压 下限");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("霍尔相差");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("相电流峰值限制");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("手柄调速电压 上限");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("手柄调速电压 下限");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("堵转保护电流");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("参数设定区", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("断开限速线");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("连接限速线");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("限速限流", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("启动方式");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("巡航功能");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("自动巡航手柄稳定时间");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("手动巡航按键保持时间");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("助力功能");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("电动巡航助力转换");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("堵转降流处理");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("松手刹防飞车");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("刹车功能");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("刹车力度");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("电机型号");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("模拟速度显示输出值");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("模拟电流显示输出值");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("三态显示");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("滑行反充电");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("多速实现");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("功能选择区", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55});
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView_List = new System.Windows.Forms.TreeView();
            this.richTextBox_Information = new System.Windows.Forms.RichTextBox();
            this.richTextBox_SelectedNode = new System.Windows.Forms.RichTextBox();
            this.myHorizontal1 = new EET.MyHorizontal();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(446, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "EET帮助文档";
            // 
            // treeView_List
            // 
            this.treeView_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_List.BackColor = System.Drawing.SystemColors.Control;
            this.treeView_List.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView_List.ForeColor = System.Drawing.Color.Navy;
            this.treeView_List.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.treeView_List.Location = new System.Drawing.Point(12, 12);
            this.treeView_List.Name = "treeView_List";
            treeNode1.Name = "节点3";
            treeNode1.Text = "从文件加载配置";
            treeNode2.Name = "节点4";
            treeNode2.Text = "保存配置到文件";
            treeNode3.Name = "节点5";
            treeNode3.Text = "打开文件夹";
            treeNode4.Name = "节点6";
            treeNode4.Text = "退出";
            treeNode5.Name = "节点7";
            treeNode5.Text = "文件";
            treeNode6.Name = "节点9";
            treeNode6.Text = "从控制器读取配置";
            treeNode7.Name = "节点10";
            treeNode7.Text = "下载配置到控制器";
            treeNode8.Name = "节点11";
            treeNode8.Text = "置顶";
            treeNode9.Name = "节点8";
            treeNode9.Text = "操作";
            treeNode10.Name = "节点12";
            treeNode10.Text = "端口";
            treeNode11.Name = "节点14";
            treeNode11.Text = "帮助文档";
            treeNode12.Name = "节点15";
            treeNode12.Text = "关于";
            treeNode13.Name = "节点13";
            treeNode13.Text = "帮助";
            treeNode14.Name = "节点0";
            treeNode14.Text = "菜单栏";
            treeNode15.Name = "节点2";
            treeNode15.Text = "状态栏";
            treeNode16.Name = "节点0";
            treeNode16.Text = "主界面";
            treeNode17.Name = "节点16";
            treeNode17.Text = "软件版本号";
            treeNode18.Name = "节点17";
            treeNode18.Text = "硬件版本号";
            treeNode19.Name = "节点18";
            treeNode19.Text = "产品型号";
            treeNode20.Name = "节点19";
            treeNode20.Text = "电机极数";
            treeNode21.Name = "节点20";
            treeNode21.Text = "共阴共阳";
            treeNode22.Name = "节点21";
            treeNode22.Text = "控制器保护温度";
            treeNode23.Name = "节点1";
            treeNode23.Text = "显示区";
            treeNode24.Name = "节点22";
            treeNode24.Text = "电机相序";
            treeNode25.Name = "节点23";
            treeNode25.Text = "电池额定电压";
            treeNode26.Name = "节点24";
            treeNode26.Text = "电池保护电压 过压";
            treeNode27.Name = "节点25";
            treeNode27.Text = "电池保护电压 欠压";
            treeNode28.Name = "节点26";
            treeNode28.Text = "霍尔";
            treeNode29.Name = "节点27";
            treeNode29.Text = "防飞车保护电压 上限";
            treeNode30.Name = "节点28";
            treeNode30.Text = "防飞车保护电压 下限";
            treeNode31.Name = "节点29";
            treeNode31.Text = "霍尔相差";
            treeNode32.Name = "节点30";
            treeNode32.Text = "相电流峰值限制";
            treeNode33.Name = "节点31";
            treeNode33.Text = "手柄调速电压 上限";
            treeNode34.Name = "节点32";
            treeNode34.Text = "手柄调速电压 下限";
            treeNode35.Name = "节点33";
            treeNode35.Text = "堵转保护电流";
            treeNode36.Name = "节点2";
            treeNode36.Text = "参数设定区";
            treeNode37.Name = "节点36";
            treeNode37.Text = "断开限速线";
            treeNode38.Name = "节点37";
            treeNode38.Text = "连接限速线";
            treeNode39.Name = "节点34";
            treeNode39.Text = "限速限流";
            treeNode40.Name = "节点35";
            treeNode40.Text = "启动方式";
            treeNode41.Name = "节点38";
            treeNode41.Text = "巡航功能";
            treeNode42.Name = "节点39";
            treeNode42.Text = "自动巡航手柄稳定时间";
            treeNode43.Name = "节点40";
            treeNode43.Text = "手动巡航按键保持时间";
            treeNode44.Name = "节点41";
            treeNode44.Text = "助力功能";
            treeNode45.Name = "节点42";
            treeNode45.Text = "电动巡航助力转换";
            treeNode46.Name = "节点43";
            treeNode46.Text = "堵转降流处理";
            treeNode47.Name = "节点44";
            treeNode47.Text = "松手刹防飞车";
            treeNode48.Name = "节点45";
            treeNode48.Text = "刹车功能";
            treeNode49.Name = "节点46";
            treeNode49.Text = "刹车力度";
            treeNode50.Name = "节点47";
            treeNode50.Text = "电机型号";
            treeNode51.Name = "节点48";
            treeNode51.Text = "模拟速度显示输出值";
            treeNode52.Name = "节点49";
            treeNode52.Text = "模拟电流显示输出值";
            treeNode53.Name = "节点50";
            treeNode53.Text = "三态显示";
            treeNode54.Name = "节点51";
            treeNode54.Text = "滑行反充电";
            treeNode55.Name = "节点52";
            treeNode55.Text = "多速实现";
            treeNode56.Name = "节点3";
            treeNode56.Text = "功能选择区";
            this.treeView_List.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode23,
            treeNode36,
            treeNode56});
            this.treeView_List.Size = new System.Drawing.Size(163, 342);
            this.treeView_List.TabIndex = 28;
            this.treeView_List.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_List_NodeMouseClick);
            // 
            // richTextBox_Information
            // 
            this.richTextBox_Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Information.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox_Information.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Information.ForeColor = System.Drawing.Color.Blue;
            this.richTextBox_Information.Location = new System.Drawing.Point(181, 137);
            this.richTextBox_Information.Name = "richTextBox_Information";
            this.richTextBox_Information.ReadOnly = true;
            this.richTextBox_Information.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Information.Size = new System.Drawing.Size(399, 217);
            this.richTextBox_Information.TabIndex = 3;
            this.richTextBox_Information.Text = "主界面包括“菜单栏”、“数据区” 及“状态栏”。\n可以进行配置的加载、保存、读取及下载等操作。\n软件操作需串口支持，需要先连接串口后再打开软件！";
            // 
            // richTextBox_SelectedNode
            // 
            this.richTextBox_SelectedNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_SelectedNode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_SelectedNode.ForeColor = System.Drawing.Color.Navy;
            this.richTextBox_SelectedNode.Location = new System.Drawing.Point(181, 100);
            this.richTextBox_SelectedNode.Name = "richTextBox_SelectedNode";
            this.richTextBox_SelectedNode.ReadOnly = true;
            this.richTextBox_SelectedNode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_SelectedNode.Size = new System.Drawing.Size(399, 31);
            this.richTextBox_SelectedNode.TabIndex = 29;
            this.richTextBox_SelectedNode.Text = "主界面";
            // 
            // myHorizontal1
            // 
            this.myHorizontal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myHorizontal1.Location = new System.Drawing.Point(181, 93);
            this.myHorizontal1.Name = "myHorizontal1";
            this.myHorizontal1.Size = new System.Drawing.Size(399, 1);
            this.myHorizontal1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(478, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ver 1.00";
            // 
            // HelpFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_SelectedNode);
            this.Controls.Add(this.treeView_List);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox_Information);
            this.Controls.Add(this.myHorizontal1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "HelpFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpFile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyHorizontal myHorizontal1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView_List;
        private System.Windows.Forms.RichTextBox richTextBox_Information;
        private System.Windows.Forms.RichTextBox richTextBox_SelectedNode;
        private System.Windows.Forms.Label label1;

    }
}