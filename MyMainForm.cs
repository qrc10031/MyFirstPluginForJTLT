using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using GeoScene.Data;
using GeoScene.Globe;
using Scodi.Rdcas.Gis3D;
using Scodi.Rdcas.MainHost.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTLTPluginDemo
{
    public partial class MyMainForm : RibbonForm,
        IModule,
        IRibbonPagesProvider,
        IGSOGlobeCreateWatcher,
        ISingleton,
        IFormClosing,
        ILoad,
        IAfterLoad
    {
        #region 框架-单例接口
        private static MyMainForm instance;
        private static readonly object locker = new object();

        public static MyMainForm GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new MyMainForm();
                    }
                }
            }
            return instance;
        }
        public static object GetSingleton()
        {
            return GetInstance();
        }
        #endregion

        //构造方法
        public MyMainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 框架-用于和经天路图主窗体通信的对象。
        /// 通过此对象，能够访问框架级的多个Manager对象。
        /// 此对象中的：
        /// FileInfos：与文件读写、项目文件信息有关的成员；
        /// DockMgr：与主窗体的可停靠子窗体控件有关的成员。例如，通过该成员可添加可停靠的DockPanel对象
        /// RibbonController：使用此成员访问主界面的RibbonControl控件
        /// ApplicationMenu：使用此成员，访问主界面的ApplicationMenu菜单栏。
        ///                                 若要向ApplicaitonMenu添加按钮，请使用AddItemToApplicationMenu方法。
        ///                                 若要向StatusBar（下方状态栏）添加按钮，请使用AddItemToStatusbar方法。
        ///                                 若要向CaptionBar（上方状态栏，有用户登录按钮的位置）添加按钮，请使用AddItemToCaptionBar方法。
        /// UserMgr：使用此成员访问与用户登录状态、身份验证有关的操作
        /// PuginsMgr：包含其他插件模块信息的成员
        /// BarManager：主窗体Ribbon的BarManager
        /// </summary>
        public MainHostMgr MainHostMgr { get => Util.MainHostMgr; set => Util.MainHostMgr = value; }

        /// <summary>
        /// 框架-此模块的Id名称。不能与其他模块重复。
        /// </summary>
        public string IdName { get; set; } = Str.ModuleName;


        //一个值，用于指示是否执行了此方法，防止二次执行。
        bool hasProvideRibbonPage = false;

        //Ribbon显隐控制器，可以方便控制所有RibbonControl按钮是否显示或隐藏
        Scodi.Rdcas.MainHost.RibbonVisibleHelper ribbonVisibleHelper;

        /// <summary>
        /// 框架-用于将自己插件中排版好的RibbonControl控件，提交给框架主程序中的RibbonControl控件。
        /// 如果不通过此方法，则自己插件中的RibbonControl控件就无法在主界面中看到！
        /// 因此，你可以在方法return之前，去除一部分RibbonControl中的某些按钮，再提交，从而实现测试功能和上线功能区分
        /// </summary>
        /// <returns></returns>
        public RibbonPage[] GetRibbonPages()
        {
            if (!hasProvideRibbonPage)
            {
                ribbonVisibleHelper = new Scodi.Rdcas.MainHost.RibbonVisibleHelper(myRibbonControl);
                hasProvideRibbonPage = true;
                ribbonVisibleHelper.RegistRibbonControlItems();
                ribbonVisibleHelper.AdjustAllElementVisibility(false);
            }

            //返回ribbonControl的所有Pages
            return myRibbonControl.Pages.ToArray();
        }

        /// <summary>
        /// 框架-初始化插件模块，此模块中需要初始化的
        /// </summary>
        public void InitializePlugin()
        {

        }


        /// <summary>
        /// 这个方法将在三维场景初始化成功后，由框架调用。并将GSOGlobeMgr对象注入此插件模块。
        /// </summary>
        /// <param name="gbcMgr"></param>
        public void DothingAfterGlobeCreate(GSOGlobeMgr gbcMgr)
        {
            //注入外部传入的参数
            Util.gbcMgr = gbcMgr;
            Util.gbc = gbcMgr.GSOGlobeControl;
            Util.LayerTvMgr = gbcMgr.Mgrs.LayerTreeMgr;
            Util.FeatureTvMgr = gbcMgr.Mgrs.FeatureTreeMgr;
            Util.LayerMnuMgr = gbcMgr.Mgrs.LayerTreeMenuMgr;
            Util.FeatureTvMnuMgr = gbcMgr.Mgrs.FeatureTreeMenuMgr;

            //将RibbonControl的控件改成可用状态
            ribbonVisibleHelper.AdjustAllElementVisibility(true);


            //注册图层树右键菜单弹出事件监测
            Util.LayerMnuMgr.BeforeTreeNodeMenuShow += LayerMnuMgr_BeforeTreeNodeMenuShow;

        }

        /// <summary>
        /// 框架-主窗体Load时，要执行的方法。
        /// 请不要使用自己窗体的Load事件，因为不会被调用。
        /// </summary>
        public void mLoad(object sender, EventArgs e)
        {
            //不要在此方法中写弹出任何窗体的代码，否则会卡主界面
        }

        /// <summary>
        /// 框架-主窗体Load完毕后，要执行的方法。
        /// 请不要使用自己窗体的Load事件，因为不会被调用。
        /// </summary>
        public void mAfterLoad(object sender, EventArgs e)
        {
            XtraMessageBox.Show("执行mAfterLoad方法");
        }

        /// <summary>
        /// 框架-主窗体即将Close要执行的方法。
        /// 请不要使用自己窗体的FormClosing事件，因为不会被调用。
        /// </summary>
        public void mFormClosing(object sender, FormClosingEventArgs e)
        {
            XtraMessageBox.Show("执行mFormClosing方法");
        }


        /// <summary>
        /// 测试按钮：增加一次自动保存参数的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var cnt = ++Params.Inst().Count;
            XtraMessageBox.Show(Util.MainHostMgr.MainForm, "此项目已点击了" + cnt + "次");
        }


        /// <summary>
        /// 测试按钮：显示子窗体
        /// </summary>
        private void btnTestDemo2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.FrmChildForm frm = new Forms.FrmChildForm();
            frm.Show(Util.MainHostMgr.MainForm);
        }


        #region 给图层树右键菜单添加新的选项，并获取点击节点的挂载数据
        bool addNewItem = false;
        /// <summary>
        /// 给图层树添加新的项
        /// </summary>
        private void btnTestDemo3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //用一个值指示，是否在下一次弹出图层树右键菜单时，显示新的选项
            addNewItem = !addNewItem;

            if (newMenuItem == null)
            {
                newMenuItem = new BarButtonItem();
                newMenuItem.Caption = "新添加的项";
                //注册该项的点击事件
                newMenuItem.ItemClick += NewMenuItem_ItemClick;
            }
        }


        //创建一个BarButtonItem，用于添加到图层树右键菜单
        BarButtonItem newMenuItem;
        private void NewMenuItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var tag = e.Item.Tag;
            if (tag != null)
            {
                XtraMessageBox.Show("该节点挂载的数据类型为" + tag.GetType().Name);
            }
            else
            {
                XtraMessageBox.Show("该节点无挂载数据");
            }

        }
        /// <summary>
        /// 图层树右键菜单弹出的事件
        /// </summary>
        private void LayerMnuMgr_BeforeTreeNodeMenuShow(object sender, PopupMenu e)
        {
            //判断，如果需要添加新的选项，则继续，否则返回
            if (addNewItem == false) return;

            //将创建好的右键菜单项添加到主菜单中
            e.AddItem(newMenuItem);
            //可以从sender中获取与点击节点相关的信息
            newMenuItem.Tag = (sender as DevExpress.XtraTreeList.Nodes.TreeListNode).Tag;
        }


        #endregion

        private void btnTestDemo4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Util.gbcMgr.InvokeDrawCommand("JTLTPluginDemo.Commands.MyCommand".ToUpper());
        }


        private void btnTestDemo5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Util.gbcMgr.InvokeDrawCommand("JTLTPluginDemo.Commands.MyPicFeatureCommand".ToUpper());
        }


        //调用现有命令
        private void btnTestDemo6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Util.gbcMgr.SimCmdPanel.InvokeCommand("Scodi.Rdcas.Gis3D.LtCommand.LtEnumAction3D.LtDrawRectange".ToUpper(),
        new Scodi.Rdcas.Gis3D.LtCommand.CmdParam_CmdDrawRectangle()
        {
            //给出绘制完成矩形后，要执行的方法
            DoAfterDraw = new Commands.MyCommandExt().DoAfterDrawRectange
        });

        }


        //调用现有选择对象命令，选择到对象后，显示该对象的几何信息
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Util.gbcMgr.SimCmdPanel.InvokeCommand("Scodi.Rdcas.Gis3D.LtCommand.LtEnumAction3D.SelectOnlyOneObj".ToUpper(),
        new Scodi.Rdcas.Gis3D.LtCommand.CmdParam_CmdSelectOnlyOneObject()
        {
            //鼠标点击对象后，执行该方法
            DoAfterSelect = new Commands.MyCommandExt().DoThingAfterSelect
        });

        }

        //获取场景中所有图层
        private void btnTestDemo7_ItemClick(object sender, ItemClickEventArgs e)
        {
            int cntVisible = 0;
            int cntInvisible = 0;

            //取得三维地球中的所有图层
            GSOLayers layers = Util.gb.Layers;

            //遍历图层
            for (int i = 0; i < layers.Count; i++)
            {
                GSOLayer layer = layers[i];

                //可以判断图层的某些属性，这里以图层的可见性进行区分判断
                if (layer.Visible)
                    cntVisible++;
                else
                    cntInvisible++;
            }
            XtraMessageBox.Show($"地球中一共{layers.Count}个图层，可见{cntVisible}个，不可见{cntInvisible}个");
        }

        //遍历获取图层中的所有要素
        private void btnTestDemo8_ItemClick(object sender, ItemClickEventArgs e)
        {
            //遍历图层，找到每个图层中的Feature个数，统计总数
            int cnt = 0;
            //（1）找到所有图层
            GSOLayers layers = Util.gb.Layers;
            for (int i = 0; i < layers.Count; i++)
            {
                GSOLayer layer = layers[i];
                //只有FeatureLayer才会有Feature
                if (layer.Type != EnumLayerType.FeatureLayer) continue;

                List<GSOFeature> fs = GlobeHelper.GetAllFeatureInLayerRecursly(layer);
                cnt += fs.Count;
            }
            XtraMessageBox.Show($"所有图层内，一共包含{cnt}个Feature");
        }
    }
}
