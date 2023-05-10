
namespace JTLTPluginDemo
{
    partial class MyMainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMainForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.myRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTestButton1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTestDemo2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTestDemo3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTestDemo4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTestDemo5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTestDemo6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnTestDemo7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTestDemo8 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.myRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // myRibbonControl
            // 
            this.myRibbonControl.ExpandCollapseItem.Id = 0;
            this.myRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.myRibbonControl.ExpandCollapseItem,
            this.myRibbonControl.SearchEditItem,
            this.btnTestButton1,
            this.btnTestDemo2,
            this.btnTestDemo3,
            this.btnTestDemo4,
            this.btnTestDemo5,
            this.btnTestDemo6,
            this.barButtonItem1,
            this.btnTestDemo7,
            this.btnTestDemo8});
            this.myRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.myRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.myRibbonControl.MaxItemId = 12;
            this.myRibbonControl.Name = "myRibbonControl";
            this.myRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.myRibbonControl.Size = new System.Drawing.Size(1669, 315);
            // 
            // btnTestButton1
            // 
            this.btnTestButton1.Caption = "自动保存参数";
            this.btnTestButton1.Id = 1;
            this.btnTestButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTestButton1.ImageOptions.Image")));
            this.btnTestButton1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTestButton1.ImageOptions.LargeImage")));
            this.btnTestButton1.Name = "btnTestButton1";
            this.btnTestButton1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestButton_ItemClick);
            // 
            // btnTestDemo2
            // 
            this.btnTestDemo2.Caption = "呼出子窗体";
            this.btnTestDemo2.Id = 2;
            this.btnTestDemo2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTestDemo2.ImageOptions.Image")));
            this.btnTestDemo2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTestDemo2.ImageOptions.LargeImage")));
            this.btnTestDemo2.Name = "btnTestDemo2";
            this.btnTestDemo2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestDemo2_ItemClick);
            // 
            // btnTestDemo3
            // 
            this.btnTestDemo3.Caption = "添加右键菜单项";
            this.btnTestDemo3.Id = 5;
            this.btnTestDemo3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTestDemo3.ImageOptions.Image")));
            this.btnTestDemo3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTestDemo3.ImageOptions.LargeImage")));
            this.btnTestDemo3.Name = "btnTestDemo3";
            toolTipItem1.Text = "给左侧图层树右键菜单添加一个新的选项";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnTestDemo3.SuperTip = superToolTip1;
            this.btnTestDemo3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestDemo3_ItemClick);
            // 
            // btnTestDemo4
            // 
            this.btnTestDemo4.Caption = "简单命令";
            this.btnTestDemo4.Id = 6;
            this.btnTestDemo4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTestDemo4.ImageOptions.Image")));
            this.btnTestDemo4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTestDemo4.ImageOptions.LargeImage")));
            this.btnTestDemo4.Name = "btnTestDemo4";
            this.btnTestDemo4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestDemo4_ItemClick);
            // 
            // btnTestDemo5
            // 
            this.btnTestDemo5.Caption = "鼠标交互命令";
            this.btnTestDemo5.Id = 7;
            this.btnTestDemo5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTestDemo5.ImageOptions.Image")));
            this.btnTestDemo5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTestDemo5.ImageOptions.LargeImage")));
            this.btnTestDemo5.Name = "btnTestDemo5";
            this.btnTestDemo5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestDemo5_ItemClick);
            // 
            // btnTestDemo6
            // 
            this.btnTestDemo6.Caption = "调用现有命令";
            this.btnTestDemo6.Id = 8;
            this.btnTestDemo6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTestDemo6.ImageOptions.Image")));
            this.btnTestDemo6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTestDemo6.ImageOptions.LargeImage")));
            this.btnTestDemo6.Name = "btnTestDemo6";
            this.btnTestDemo6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestDemo6_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "选择对象显示信息";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "我的RibbonPage";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTestButton1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTestDemo2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "分组";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTestDemo3);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTestDemo7);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTestDemo8);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "图层树操作";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTestDemo4);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTestDemo5);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTestDemo6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "命令系统";
            // 
            // btnTestDemo7
            // 
            this.btnTestDemo7.Caption = "获取所有图层";
            this.btnTestDemo7.Id = 10;
            this.btnTestDemo7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnTestDemo7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnTestDemo7.Name = "btnTestDemo7";
            this.btnTestDemo7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestDemo7_ItemClick);
            // 
            // btnTestDemo8
            // 
            this.btnTestDemo8.Caption = "获取图层要素";
            this.btnTestDemo8.Id = 11;
            this.btnTestDemo8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnTestDemo8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnTestDemo8.Name = "btnTestDemo8";
            this.btnTestDemo8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestDemo8_ItemClick);
            // 
            // MyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 884);
            this.Controls.Add(this.myRibbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyMainForm";
            this.Ribbon = this.myRibbonControl;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl myRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTestButton1;
        private DevExpress.XtraBars.BarButtonItem btnTestDemo2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTestDemo3;
        private DevExpress.XtraBars.BarButtonItem btnTestDemo4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTestDemo5;
        private DevExpress.XtraBars.BarButtonItem btnTestDemo6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTestDemo7;
        private DevExpress.XtraBars.BarButtonItem btnTestDemo8;
    }
}

