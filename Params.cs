using RuntimeConfigKernel.RuntimeMonitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTLTPluginDemo
{
    /// <summary>
    /// 这个类存放本模块需要的运行配置参数。
    /// </summary>
    public class Params
    {

        #region 框架
        private static Params instance;
        internal static Params Inst()
        {
            if (instance == null)
            {
                instance = new Params();
            }
            return instance;
        }

        internal (bool exeResult, string errMsg) Load()
        {
            //配置文件保存路径
            string configPath = Str.dirProjectSave + "\\Params.json";
            return SimpleSerilizableParaAttributeMgr.Load(configPath, this);
        }



        internal (bool exeResult, string errMsg) Save()
        {
            //配置文件保存路径
            string configPath = Str.dirProjectSave + "\\Params.json";
            return SimpleSerilizableParaAttributeMgr.Save(this, configPath);
        }

        #endregion

        /// <summary>
        /// 初始化配置，在此方法中将参数还原成初始值
        /// </summary>
        internal void Reset()
        {
            instance = new Params();
        }

        /// <summary>
        /// 测试用的配置属性。
        /// 用于显示此按钮被点击的次数。
        /// </summary>
        [SimpleSerilizableParaAttribute]
        public int Count { get; set; } = 0;


    }

}
