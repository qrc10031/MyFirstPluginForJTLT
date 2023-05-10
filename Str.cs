using System.IO;
using System.Text;

namespace JTLTPluginDemo
{
    /// <summary>
    /// 用于存储静态字符串的类，便于被模块访问
    /// </summary>
    class Str
    {
        internal static string ModuleName { get; set; } = "我的第一个经天路图插件";
        /// <summary>
        /// 插件保存时，保存的文件夹路径
        /// </summary>
        public static string dirProjectSave => Path.Combine(Util.MainHostMgr.FileInfos.SvDir, "MyFirstPluginForJTLT");

    }
}
