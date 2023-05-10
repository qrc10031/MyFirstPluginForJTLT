using DevExpress.XtraEditors;
using Scodi.Rdcas.Gis3D.LtCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTLTPluginDemo.Commands
{
    /// <summary>
    /// 写一个普通的经天路图命令，改命令不包含硬件交互，只包含最基本的：
    /// （1）激活-Fire
    /// （2）完成-Finish
    /// （3）取消-Cancel
    /// </summary>
    [LtCommandAttribute("JTLTPluginDemo.Commands.MyCommand", "MyCommand", "我的第一个命令")]
    public class MyCommand : ICommandExt
    {
        public override void Fire(params object[] para)
        {
            XtraMessageBox.Show("激活了命令");
        }


        //只继承ICommandExt，不会触发此方法
        public override void Finish(params object[] para) { }

        //只继承ICommandExt，不会触发此方法
        public override void Cancel(params object[] para) { }

    }
}
