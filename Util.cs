using GeoScene.Globe;
using Scodi.Rdcas.Gis3D;
using Scodi.Rdcas.Gis3D.DataSupport;
using Scodi.Rdcas.Gis3D.LayerTree;
using Scodi.Rdcas.MainHost.Extension;


namespace JTLTPluginDemo
{
    /// <summary>
    /// 这个类存放全局可访问的静态成员。
    /// 目的是便于访问。
    /// </summary>
    class Util
    {

        /// <summary>
        /// 三维地球控件对象
        /// </summary>
        internal static GSOGlobeControl gbc;

        /// <summary>
        /// 三维地球对象
        /// </summary>
        internal static GSOGlobe gb => gbc.Globe;

        /// <summary>
        /// 二次开发后，封装了大量辅助对象的三维地球管理器对象
        /// </summary>
        internal static GSOGlobeMgr gbcMgr;

        /// <summary>
        /// 图层树管理器。通过此对象可访问图层树以及图层树的信息。十分重要
        /// </summary>
        internal static GlobeLayerTreeMgr LayerTvMgr { get; set; }

        /// <summary>
        /// 图元树管理器。通过此对象可访问图层树下部的图元树信息。十分重要
        /// </summary>
        internal static FeatureTreeMgr FeatureTvMgr { get; set; }

        /// <summary>
        /// 图层树右键菜单管理器。可以通过此对象添加右键菜单项。
        /// </summary>
        internal static LayerTreePopupMenuMgr LayerMnuMgr { get; set; }

        /// <summary>
        /// 图元树右键菜单管理器。可以通过此对象添加右键菜单项。
        /// </summary>
        internal static FeatureTreePopupMenuMgr FeatureTvMnuMgr { get; set; }

        /// <summary>
        /// 经天路图主窗体管理器对象。该对象注入在MyMainForm中完成。
        /// </summary>
        internal static MainHostMgr MainHostMgr { get; set; }

       /// <summary>
       /// 二次开发后，封装了与三维地球操作事件（Event）相关的管理器对象。
       /// 从此对象中，可以注册很多三维地球本身没有的事件
       /// </summary>
        internal static GSOEventMgr GSOEventMgr { get; set; }

        /// <summary>
        /// 二次开发后，封装了与三维地球样式有关的对象
        /// </summary>
        internal static DefaultStyleMgr StyleMgr { get; set; } = DefaultStyleMgr.GetInstance();


    }
}
