using DevExpress.XtraEditors;
using GeoScene.Data;
using GeoScene.Globe;
using Scodi.Rdcas.Gis3D.LtCommand;
using System.Drawing;
using System.Windows.Forms;

namespace JTLTPluginDemo.Commands
{
    /// <summary>
    /// 这是与三维地球有鼠标、键盘交互的命令，可用于例如绘制线、选择对象等操作
    /// </summary>
    [LtCommandAttribute("JTLTPluginDemo.Commands.MyPicFeatureCommand", "MyPicFeatureCommand", "我的第一个拾取命令")]
    public class MyPicFeatureCommand : IDrawCommandExt
    {
        public MyPicFeatureCommand(GSOGlobeControl gbc) : base(gbc)
        {

        }

        /*手动根据需要，实现鼠标、键盘事件监测，
         可以使用F12，观察IDrawCommandExt类成员*/


        Point msDown;
        /// <summary>
        /// 鼠标按下事件
        /// </summary>
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            //只响应鼠标左键点击
            if (e.Button != MouseButtons.Left) return;

            base.MouseDown(sender, e);

            //记录鼠标按下的位置
            msDown = e.Location;
        }

        /// <summary>
        /// 鼠标抬起事件
        /// </summary>
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            base.MouseUp(sender, e);

            //对比鼠标抬起的位置，如果距离太远，说明是拖动地球，不是点击
            if (!IsTwoPointProxEqual(msDown, e.Location))
                return;

            //尝试获取鼠标点击位置的场景图新元素
            //layer，如果给定鼠标位置有Feature对象，则返回该对象所在图层layer，同时返回该对象的空间点位坐标
            var f = GetFeatureAtPt(e.Location, out GSOLayer layer, out GSOPoint3d point);
            if (f == null) return;

            XtraMessageBox.Show("选中了Feature:" + f.Name + "\n类型:" + f.Geometry.Type + "\n所在图层+" + layer.Caption + "\n坐标：" + point);
        }


        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            base.MouseMove(sender, e);
        }

        /// <summary>
        /// 键盘按键按下
        /// </summary>
        public override void KeyDown(object sender, KeyEventArgs e)
        {
            base.KeyDown(sender, e);
        }

    }
}
