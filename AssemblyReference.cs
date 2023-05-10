using SCODI.BIM.WITF.Cho.CommonHelper;


/// <summary>
/// 这个文件用于解决第三方引用库找不到引用的问题。
/// 以及：软件中存在相同名称的代码库，但是版本不
/// 同的情况。
/// 
/// 
/// 【腾讯文档】依赖引用私有路径和依赖引用重定向
///   https://docs.qq.com/doc/DWnBVSnFiVkhSeEt4
///   
/// 
/// </summary>


/*       如果要添加代码引用，请接触下一行的注释
 *       该行代码的含义是：告诉主程序，如果出现找不到dll的情况，
 *       就尝试到该文件夹中寻找。
 *       如果你的插件所在文件夹名称不是“MyNewPlugin”，则请根据
 *       你自己的文件夹名称修改。
 *       
 *       如果有多个文件夹路径，则手动复制并添加多条
 */
//[assembly: LibPrivatePathAtrribute(@"Plugins\MyNewPlugin\")]



/*        引用重绑定
 *        该代码的含义是：告诉程序，对于EPPlus这个第三方代码库，如果发现某个位置引用了
 *        EPPlus，且EPPlus.dll的publicKeyToken为ea159fdaa78159a1，并且版本为“5.7.0.0”，那么
 *        就到“Plugins\3DGISRoadDesign\libs\EPPlus.dll”路径下去寻找，最后一个参数不用关心，
 *        照着写即可。
 *        当有多个dll需要进行重绑定时，需要分别添加多行代码
 *        具体说明，可参照上面给的腾讯文档。
 * 
 * */
//[assembly: LibDependent("EPPlus", "ea159fdaa78159a1", "5.7.0.0", @"Plugins\3DGISRoadDesign\libs\EPPlus.dll", "neutral")]



