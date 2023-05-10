using DevExpress.XtraEditors;
using GeoScene.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTLTPluginDemo.Commands
{
    /// <summary>
    /// 写一个扩展命令，利用已经有的基础命令，扩展新的功能
    /// 【腾讯文档】经天路图3D-GIS模块调用基础命令形成组合命令操作
    ///    https://docs.qq.com/doc/DWmREQVhrTFJRckZx
    /// </summary>
    public class MyCommandExt
    {

        /*
         数据结构关系

        GSOFeature：对象要素，可以看做是一个容器，内部可以装各种几何体，也包括空几何体

        GSOGeometry：几何对象的基类，可以用图形化的方式显示的几何元素，几何对象要显示在
                                    三维地球中，必须要放在Feature内

        GSOGeoPolygon：多边形几何，继承自GSOGeometry。属于几何对象的实体，与之类似的，
                                      常用几何还包含：
                                      （1）GSOGeoPolyline：多段线（直线相当于只有两个点的多段线）
                                      （2）GSOGeoMarker：标记点，带有图标的一个点对象
                                     （3）GSOGeoPoint：点

        关系：
        地球  包含  多个GSOFeature   ,一个Feature包含一个Geometry

        获取：
        要获取一个几何对象，首先要获取Feature，再从Feature的Geometry属性中，取得几何对象
        
        注意：
        不同的几何对象，有不同的数据结构描述，例如：
                （1）点：只包含一个GSOPoint3d
                （2）多段线：包含多个Part，每个Part存储GSOPoint3ds对象，存储一组点集，即，多断线可以有多个零散的子线段
                （3）多边形：包含多个Part，每个Part存储一组GSOPoint3ds对象，即，多边形可以有多个零散的子区域

        因此，处理几何对象时，在不预先确定取得的几何类型时，需要先判断几何类型，再根据类型处理。

         */



        /// <summary>
        /// 绘制矩形后，要执行的方法
        /// </summary>
        /// <param name="arg1">绘制的矩形的Feature</param>
        /// <param name="arg2">绘制的矩形Feature内包含的几何对象（矩形本体）</param>
        internal void DoAfterDrawRectange(GSOFeature arg1, GSOGeoPolygon3D arg2)
        {
            XtraMessageBox.Show($"feature ID = {arg1.ID}\npolygon面积：{arg2.Area:0.000㎡}");
        }


        /// <summary>
        /// 鼠标点击对象后，执行方法
        /// </summary>
        /// <param name="obj">选择到的要素</param>
        internal void DoThingAfterSelect(GSOFeature obj)
        {
            //判断Feature是否包含了Geometry，某些Feature可能不包含几何，不判断的话，会出错
            if (obj.Geometry == null) return;

            //判断Geometry的类型
            //Geometry.Type类型多达200多种，常用的类型只有几种，所以手动填写，不使用VisualStudio的自动生成功能
            switch (obj.Geometry.Type)
            {
                case EnumGeometryType.GeoPolyline3D:
                    {
                        //多段线，拆箱获得
                        var line = obj.Geometry as GSOGeoPolyline3D;

                        //线段的子区域数量
                        var partCnt = line.PartCount;
                        //遍历子区域
                        string msg = "";
                        for (int i = 0; i < partCnt; i++)
                        {
                            msg += $"索引{i}的Part：";
                            //取出第i个子区域的点集合
                            GSOPoint3ds pts = line[i];
                            for (int j = 0; j < pts.Count; j++)
                            {
                                //取点
                                GSOPoint3d pt = pts[j];
                                msg += $"\n第{j}个点：X-{pt.X}   Y-{pt.Y}   Z-{pt.Z}";
                            }
                        }
                        XtraMessageBox.Show("拾取到了多段线：\n" + msg);

                        break;
                    }
                case EnumGeometryType.GeoPolygon3D:
                    {
                        //多边形
                        var polygon = obj.Geometry as GSOGeoPolygon3D;

                        //多边形的子区域数量
                        var partCnt = polygon.PartCount;
                        //遍历子区域
                        string msg = "";
                        for (int i = 0; i < partCnt; i++)
                        {
                            msg += $"索引{i}的Part：";
                            //取出第i个子区域的点集合
                            GSOPoint3ds pts = polygon[i];
                            for (int j = 0; j < pts.Count; j++)
                            {
                                //取点
                                GSOPoint3d pt = pts[j];
                                msg += $"\n第{j}个点：X-{pt.X}   Y-{pt.Y}   Z-{pt.Z}";
                            }
                        }
                        XtraMessageBox.Show("拾取到了多边形线：\n" + msg);

                        break;
                    }
                default:
                    {
                        XtraMessageBox.Show($"暂时无法处理{obj.Geometry.Type}类型");
                    }
                    break;
            }
        }
    }
}
