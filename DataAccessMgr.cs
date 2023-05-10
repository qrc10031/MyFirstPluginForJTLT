using Scodi.Rdcas.MainHost.Extension;
using Scodi.Rdcas.MainHost.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTLTPluginDemo.DataSupport
{
    /// <summary>
    /// 这个类负责与框架的项目文件系统协同。包括：
    /// （1）新建项目
    /// （2）保存项目
    /// （3）打开项目
    /// </summary>
    public class DataAccessMgr : IFSOperatonProvider, ISingleton
    {
        #region 框架-单例
        private static DataAccessMgr instance;
        private static readonly object locker = new object();
        public static object GetSingleton()
        {
            return GetInstance();
        }
        public static DataAccessMgr GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DataAccessMgr();
                    }
                }
            }
            return instance;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        private DataAccessMgr()
        {

        }
        #endregion



        public string IdName { get; set; } = Str.ModuleName;

        /// <summary>
        /// 框架打开项目时，会调用此方法。
        /// 方法返回本模块读取数据的结果
        /// </summary>
        /// <returns></returns>
        public DataAccessResult Load()
        {
            DataAccessResult result = new DataAccessResult()
            { IsSucess = true, ModuleName = Str.ModuleName };
            try
            {
                //读取配置文件
                Params.Inst().Load();
            }
            catch (Exception ex)
            {
                result.IsSucess = false;
                result.LsMsg.Add(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// 框架新建项目时，会调用此方法。
        /// 方法返回本模块新建数据的结果
        /// 
        /// 注意：新建项目相当于是清空数据
        /// 
        /// </summary>
        /// <returns></returns>
        public DataAccessResult Reset()
        {
            DataAccessResult result = new DataAccessResult()
            { IsSucess = true, ModuleName = Str.ModuleName };
            try
            {
                //初始化配置
                Params.Inst().Reset();

            }
            catch (Exception ex)
            {
                result.IsSucess = false;
                result.LsMsg.Add(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// 框架保存项目时，会调用此方法。
        /// 方法返回本模块保存数据的结果
        /// </summary>
        /// <returns></returns>
        public DataAccessResult Save()
        {
            DataAccessResult result = new DataAccessResult()
            { IsSucess = true, ModuleName = Str.ModuleName };
            try
            {
                //（1）校验保存项目的文件夹路径
                if (!Directory.Exists(Str.dirProjectSave))
                {
                    Directory.CreateDirectory(Str.dirProjectSave);
                }

                //保存配置
                var re = Params.Inst().Save();

            }
            catch (Exception ex)
            {
                result.IsSucess = false;
                result.LsMsg.Add(ex.Message);
            }
            return result;

        }
    }
}
