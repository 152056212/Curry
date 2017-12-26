using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace BLL
{
    public class BLLSHStatics
    {
        private DAL.DAlSHStaticis daStatics;
        
        //仓库库存统计
        //List<int> txData2 = new List<int>() { 2011, 2012, 2013, 2014, 2015, 2016 };
        //List<int> tyData2 = new List<int>() { 49, 6, 7, 4, 5, 4 };
        List<string> txData2;
        List<int> tyData2;


        List<int> txData3 = new List<int>() { 2012 };
        List<int> tyData3 = new List<int>() { 7 };

        public BLLSHStatics() {
             daStatics = new DAL.DAlSHStaticis();
        }

        public void getKuCunTJ( Chart chat  ) {

            txData2 = daStatics.StoNo;
            tyData2 = daStatics.StoNum_StoHou;

            Chart ct = chat;
            //若为new一个Chart，需同时Add其Title，Series,ChartAreas等属性
            //若是直接拖入控件则只需在控件属性中自己调整就好
            
            //背景
            ct.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;       //X轴上网格
            ct.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;      //y轴上网格
            ct.ChartAreas[0].Axes[0].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[0].MajorTickMark.Enabled = false;                   //  x轴上突出的小点
            ct.ChartAreas[0].Axes[1].MajorTickMark.Enabled = false;                  //
            ct.ChartAreas[0].Axes[1].IsInterlaced = true;  //显示交错带 
            ct.ChartAreas[0].Axes[0].LabelStyle.Format = "#仓库";                      //设置X轴显示样式
            ct.ChartAreas[0].Axes[1].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[1].MajorGrid.LineWidth = 3;
            //图表数据区，有多个重叠则循环添加
            ct.Series.Add(new Series()); //添加一个图表序列
            // ct.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            ct.Series[0].Label = "#VAL";                //设置显示X Y的值    
            ct.Series[0].ToolTip = "#VALX仓库\r#VAL";     //鼠标移动到对应点显示数值
            ct.Series[0].ChartArea = "ca1";                   //设置图表背景框
            //ct.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)
            ct.Series[0].ChartType = SeriesChartType.Column;
            ct.Series[0].Points.DataBindXY(txData2, tyData2); //添加数据
            //折线段配置
            ct.Series[0].Color = Color.Red;               //线条颜色
            ct.Series[0].BorderWidth = 3;                 //线条粗细
            ct.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            ct.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            ct.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            ct.Series[0].MarkerSize = 2;                 //标记点大小
            ct.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //ct.Series.Add(new Series()); //添加一个图表序列
            //ct.Series[1].Label = "#VAL";                //设置显示X Y的值
            //ct.Series[1].ToolTip = "#VALX年\r#VAL";     //鼠标移动到对应点显示数值
            //ct.Series[1].ChartType = SeriesChartType.Line;    //图类型(折线)
            //ct.Series[1].Points.DataBindXY(txData3, tyData3); //添加数据
            ////折线段配置
            //ct.Series[1].Color = Color.Black;               //线条颜色
            //ct.Series[1].BorderWidth = 3;                   //线条粗细
            //ct.Series[1].MarkerBorderColor = Color.Black;   //标记点边框颜色
            //ct.Series[1].MarkerBorderWidth = 3;             //标记点边框大小
            //ct.Series[1].MarkerColor = Color.Black;         //标记点中心颜色
            //ct.Series[1].MarkerSize = 5;                    //标记点大小
            //ct.Series[1].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //另外
            //饼图说明设置，这用来设置饼图每一块的信息显示在什么地方
            ct.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ct.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            //柱状图其他设置
            ct.Series[0]["DrawingStyle"] = "Cylinder";   //设置柱状平面形状
            ct.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
        }
        
        public void getMonthInTJ( Chart chat ){

            List<int> txData2 = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12 };
            List<int> ydata2 = new List<int>();
            for (int i = 0; i < txData2.Count; i++)
            {
                bool isExsits = false;
                for (int k = 0; k < daStatics.InMonthNo.Count;k++ )
                {
                    if (daStatics.InMonthNo[k] == txData2[i])
                    {
                        ydata2.Add(daStatics.MonthInNum[k]);
                        isExsits = true;
                        break;
                    }
                    if (!isExsits)
                    {
                        ydata2.Add(0);
                    } 
                }

            }
            List<int> tyData2 = ydata2;

            Chart ct = chat;
            //若为new一个Chart，需同时Add其Title，Series,ChartAreas等属性
            //若是直接拖入控件则只需在控件属性中自己调整就好

            //背景
            ct.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;       //X轴上网格
            ct.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;      //y轴上网格
            ct.ChartAreas[0].Axes[0].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[0].MajorTickMark.Enabled = false;                   //  x轴上突出的小点
            ct.ChartAreas[0].Axes[1].MajorTickMark.Enabled = false;                  //
            ct.ChartAreas[0].Axes[1].IsInterlaced = true;  //显示交错带 
            ct.ChartAreas[0].Axes[0].LabelStyle.Format = "#仓库";                      //设置X轴显示样式
            ct.ChartAreas[0].Axes[1].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[1].MajorGrid.LineWidth = 3;
            //图表数据区，有多个重叠则循环添加
            ct.Series.Add(new Series()); //添加一个图表序列
            // ct.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            ct.Series[0].Label = "#VAL";                //设置显示X Y的值    
            ct.Series[0].ToolTip = "#VALX仓库\r#VAL";     //鼠标移动到对应点显示数值
            ct.Series[0].ChartArea = "ca1";                   //设置图表背景框
            //ct.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)
            ct.Series[0].ChartType = SeriesChartType.Column;
            ct.Series[0].Points.DataBindXY(txData2, tyData2); //添加数据
            //折线段配置
            ct.Series[0].Color = Color.Red;               //线条颜色
            ct.Series[0].BorderWidth = 3;                 //线条粗细
            ct.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            ct.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            ct.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            ct.Series[0].MarkerSize = 2;                 //标记点大小
            ct.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //ct.Series.Add(new Series()); //添加一个图表序列
            //ct.Series[1].Label = "#VAL";                //设置显示X Y的值
            //ct.Series[1].ToolTip = "#VALX年\r#VAL";     //鼠标移动到对应点显示数值
            //ct.Series[1].ChartType = SeriesChartType.Line;    //图类型(折线)
            //ct.Series[1].Points.DataBindXY(txData3, tyData3); //添加数据
            ////折线段配置
            //ct.Series[1].Color = Color.Black;               //线条颜色
            //ct.Series[1].BorderWidth = 3;                   //线条粗细
            //ct.Series[1].MarkerBorderColor = Color.Black;   //标记点边框颜色
            //ct.Series[1].MarkerBorderWidth = 3;             //标记点边框大小
            //ct.Series[1].MarkerColor = Color.Black;         //标记点中心颜色
            //ct.Series[1].MarkerSize = 5;                    //标记点大小
            //ct.Series[1].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //另外
            //饼图说明设置，这用来设置饼图每一块的信息显示在什么地方
            ct.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ct.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            //柱状图其他设置
            ct.Series[0]["DrawingStyle"] = "Cylinder";   //设置柱状平面形状
            ct.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
        }

        public void getMonthOutTJ( Chart chat ) {

            List<int> txData2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> ydata2 = new List<int>();
            for (int i = 0; i < txData2.Count; i++)
            {
                bool isExsits = false;
                for (int k = 0; k < daStatics.OutMonthNo.Count; k++)
                {
                    if (daStatics.OutMonthNo[k] == txData2[i])
                    {
                        ydata2.Add(daStatics.MonthOutNum[k]);
                        isExsits = true;
                        break;
                    }
                    if (!isExsits)
                    {
                        ydata2.Add(0);
                    }
                }

            }
            List<int> tyData2 = ydata2;

            Chart ct = chat;
            //若为new一个Chart，需同时Add其Title，Series,ChartAreas等属性
            //若是直接拖入控件则只需在控件属性中自己调整就好

            //背景
            ct.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;       //X轴上网格
            ct.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;      //y轴上网格
            ct.ChartAreas[0].Axes[0].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[0].MajorTickMark.Enabled = false;                   //  x轴上突出的小点
            ct.ChartAreas[0].Axes[1].MajorTickMark.Enabled = false;                  //
            ct.ChartAreas[0].Axes[1].IsInterlaced = true;  //显示交错带 
            ct.ChartAreas[0].Axes[0].LabelStyle.Format = "#仓库";                      //设置X轴显示样式
            ct.ChartAreas[0].Axes[1].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[1].MajorGrid.LineWidth = 3;
            //图表数据区，有多个重叠则循环添加
            ct.Series.Add(new Series()); //添加一个图表序列
            // ct.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            ct.Series[0].Label = "#VAL";                //设置显示X Y的值    
            ct.Series[0].ToolTip = "#VALX仓库\r#VAL";     //鼠标移动到对应点显示数值
            ct.Series[0].ChartArea = "ca1";                   //设置图表背景框
            //ct.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)
            ct.Series[0].ChartType = SeriesChartType.Column;
            ct.Series[0].Points.DataBindXY(txData2, tyData2); //添加数据
            //折线段配置
            ct.Series[0].Color = Color.Red;               //线条颜色
            ct.Series[0].BorderWidth = 3;                 //线条粗细
            ct.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            ct.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            ct.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            ct.Series[0].MarkerSize = 2;                 //标记点大小
            ct.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //ct.Series.Add(new Series()); //添加一个图表序列
            //ct.Series[1].Label = "#VAL";                //设置显示X Y的值
            //ct.Series[1].ToolTip = "#VALX年\r#VAL";     //鼠标移动到对应点显示数值
            //ct.Series[1].ChartType = SeriesChartType.Line;    //图类型(折线)
            //ct.Series[1].Points.DataBindXY(txData3, tyData3); //添加数据
            ////折线段配置
            //ct.Series[1].Color = Color.Black;               //线条颜色
            //ct.Series[1].BorderWidth = 3;                   //线条粗细
            //ct.Series[1].MarkerBorderColor = Color.Black;   //标记点边框颜色
            //ct.Series[1].MarkerBorderWidth = 3;             //标记点边框大小
            //ct.Series[1].MarkerColor = Color.Black;         //标记点中心颜色
            //ct.Series[1].MarkerSize = 5;                    //标记点大小
            //ct.Series[1].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //另外
            //饼图说明设置，这用来设置饼图每一块的信息显示在什么地方
            ct.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ct.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            //柱状图其他设置
            ct.Series[0]["DrawingStyle"] = "Cylinder";   //设置柱状平面形状
            ct.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
        }

        public void getProTypeTJ(Chart chat) {

            List<string> txData2 = new List<string>();
            for (int i = 0; i < daStatics.ProductType.Count;i++ )
            {
                txData2.Add(daStatics.set_Type_Name()[daStatics.ProductType[i]]);
            }
            tyData2 = daStatics.StoNum_Type;

            Chart ct = chat;
            //若为new一个Chart，需同时Add其Title，Series,ChartAreas等属性
            //若是直接拖入控件则只需在控件属性中自己调整就好

            //背景
            ct.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;       //X轴上网格
            ct.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;      //y轴上网格
            ct.ChartAreas[0].Axes[0].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[0].MajorTickMark.Enabled = false;                   //  x轴上突出的小点
            ct.ChartAreas[0].Axes[1].MajorTickMark.Enabled = false;                  //
            ct.ChartAreas[0].Axes[1].IsInterlaced = true;  //显示交错带 
            ct.ChartAreas[0].Axes[0].LabelStyle.Format = "#仓库";                      //设置X轴显示样式
            ct.ChartAreas[0].Axes[1].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[1].MajorGrid.LineWidth = 3;
            //图表数据区，有多个重叠则循环添加
            ct.Series.Add(new Series()); //添加一个图表序列
            // ct.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            ct.Series[0].Label = "#VAL";                //设置显示X Y的值    
            ct.Series[0].ToolTip = "#VALX仓库\r#VAL";     //鼠标移动到对应点显示数值
            ct.Series[0].ChartArea = "ca1";                   //设置图表背景框
            //ct.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)
            ct.Series[0].ChartType = SeriesChartType.Column;
            ct.Series[0].Points.DataBindXY(txData2, tyData2); //添加数据
            //折线段配置
            ct.Series[0].Color = Color.Red;               //线条颜色
            ct.Series[0].BorderWidth = 3;                 //线条粗细
            ct.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            ct.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            ct.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            ct.Series[0].MarkerSize = 2;                 //标记点大小
            ct.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //ct.Series.Add(new Series()); //添加一个图表序列
            //ct.Series[1].Label = "#VAL";                //设置显示X Y的值
            //ct.Series[1].ToolTip = "#VALX年\r#VAL";     //鼠标移动到对应点显示数值
            //ct.Series[1].ChartType = SeriesChartType.Line;    //图类型(折线)
            //ct.Series[1].Points.DataBindXY(txData3, tyData3); //添加数据
            ////折线段配置
            //ct.Series[1].Color = Color.Black;               //线条颜色
            //ct.Series[1].BorderWidth = 3;                   //线条粗细
            //ct.Series[1].MarkerBorderColor = Color.Black;   //标记点边框颜色
            //ct.Series[1].MarkerBorderWidth = 3;             //标记点边框大小
            //ct.Series[1].MarkerColor = Color.Black;         //标记点中心颜色
            //ct.Series[1].MarkerSize = 5;                    //标记点大小
            //ct.Series[1].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //另外
            //饼图说明设置，这用来设置饼图每一块的信息显示在什么地方
            ct.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ct.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            //柱状图其他设置
            ct.Series[0]["DrawingStyle"] = "Cylinder";   //设置柱状平面形状
            ct.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
        
        }

        public void getInTyoeTJ(Chart chat) {

            txData2 = daStatics.StoInType;
            tyData2 = daStatics.StoNum_stoInType;

            Chart ct = chat;
            //若为new一个Chart，需同时Add其Title，Series,ChartAreas等属性
            //若是直接拖入控件则只需在控件属性中自己调整就好

            //背景
            ct.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;       //X轴上网格
            ct.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;      //y轴上网格
            ct.ChartAreas[0].Axes[0].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[0].MajorTickMark.Enabled = false;                   //  x轴上突出的小点
            ct.ChartAreas[0].Axes[1].MajorTickMark.Enabled = false;                  //
            ct.ChartAreas[0].Axes[1].IsInterlaced = true;  //显示交错带 
            ct.ChartAreas[0].Axes[0].LabelStyle.Format = "#仓库";                      //设置X轴显示样式
            ct.ChartAreas[0].Axes[1].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[1].MajorGrid.LineWidth = 3;
            //图表数据区，有多个重叠则循环添加
            ct.Series.Add(new Series()); //添加一个图表序列
            // ct.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            ct.Series[0].Label = "#VAL";                //设置显示X Y的值    
            ct.Series[0].ToolTip = "#VALX仓库\r#VAL";     //鼠标移动到对应点显示数值
            ct.Series[0].ChartArea = "ca1";                   //设置图表背景框
            //ct.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)
            ct.Series[0].ChartType = SeriesChartType.Column;
            ct.Series[0].Points.DataBindXY(txData2, tyData2); //添加数据
            //折线段配置
            ct.Series[0].Color = Color.Red;               //线条颜色
            ct.Series[0].BorderWidth = 3;                 //线条粗细
            ct.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            ct.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            ct.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            ct.Series[0].MarkerSize = 2;                 //标记点大小
            ct.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //ct.Series.Add(new Series()); //添加一个图表序列
            //ct.Series[1].Label = "#VAL";                //设置显示X Y的值
            //ct.Series[1].ToolTip = "#VALX年\r#VAL";     //鼠标移动到对应点显示数值
            //ct.Series[1].ChartType = SeriesChartType.Line;    //图类型(折线)
            //ct.Series[1].Points.DataBindXY(txData3, tyData3); //添加数据
            ////折线段配置
            //ct.Series[1].Color = Color.Black;               //线条颜色
            //ct.Series[1].BorderWidth = 3;                   //线条粗细
            //ct.Series[1].MarkerBorderColor = Color.Black;   //标记点边框颜色
            //ct.Series[1].MarkerBorderWidth = 3;             //标记点边框大小
            //ct.Series[1].MarkerColor = Color.Black;         //标记点中心颜色
            //ct.Series[1].MarkerSize = 5;                    //标记点大小
            //ct.Series[1].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //另外
            //饼图说明设置，这用来设置饼图每一块的信息显示在什么地方
            ct.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ct.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            //柱状图其他设置
            ct.Series[0]["DrawingStyle"] = "Cylinder";   //设置柱状平面形状
            ct.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
        }

        public void getOutTyoeTJ(Chart chat)
        {

            txData2 = daStatics.StoOutType;
            tyData2 = daStatics.StoNum_outType;

            Chart ct = chat;
            //若为new一个Chart，需同时Add其Title，Series,ChartAreas等属性
            //若是直接拖入控件则只需在控件属性中自己调整就好

            //背景
            ct.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;       //X轴上网格
            ct.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;      //y轴上网格
            ct.ChartAreas[0].Axes[0].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[0].MajorTickMark.Enabled = false;                   //  x轴上突出的小点
            ct.ChartAreas[0].Axes[1].MajorTickMark.Enabled = false;                  //
            ct.ChartAreas[0].Axes[1].IsInterlaced = true;  //显示交错带 
            ct.ChartAreas[0].Axes[0].LabelStyle.Format = "#仓库";                      //设置X轴显示样式
            ct.ChartAreas[0].Axes[1].MajorGrid.LineDashStyle = ChartDashStyle.Dash;   //网格类型 短横线
            ct.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.Gray;
            ct.ChartAreas[0].Axes[1].MajorGrid.LineWidth = 3;
            //图表数据区，有多个重叠则循环添加
            ct.Series.Add(new Series()); //添加一个图表序列
            // ct.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            ct.Series[0].Label = "#VAL";                //设置显示X Y的值    
            ct.Series[0].ToolTip = "#VALX仓库\r#VAL";     //鼠标移动到对应点显示数值
            ct.Series[0].ChartArea = "ca1";                   //设置图表背景框
            //ct.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)
            ct.Series[0].ChartType = SeriesChartType.Column;
            ct.Series[0].Points.DataBindXY(txData2, tyData2); //添加数据
            //折线段配置
            ct.Series[0].Color = Color.Red;               //线条颜色
            ct.Series[0].BorderWidth = 3;                 //线条粗细
            ct.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            ct.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            ct.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            ct.Series[0].MarkerSize = 2;                 //标记点大小
            ct.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //ct.Series.Add(new Series()); //添加一个图表序列
            //ct.Series[1].Label = "#VAL";                //设置显示X Y的值
            //ct.Series[1].ToolTip = "#VALX年\r#VAL";     //鼠标移动到对应点显示数值
            //ct.Series[1].ChartType = SeriesChartType.Line;    //图类型(折线)
            //ct.Series[1].Points.DataBindXY(txData3, tyData3); //添加数据
            ////折线段配置
            //ct.Series[1].Color = Color.Black;               //线条颜色
            //ct.Series[1].BorderWidth = 3;                   //线条粗细
            //ct.Series[1].MarkerBorderColor = Color.Black;   //标记点边框颜色
            //ct.Series[1].MarkerBorderWidth = 3;             //标记点边框大小
            //ct.Series[1].MarkerColor = Color.Black;         //标记点中心颜色
            //ct.Series[1].MarkerSize = 5;                    //标记点大小
            //ct.Series[1].MarkerStyle = MarkerStyle.Circle;  //标记点类型

            //另外
            //饼图说明设置，这用来设置饼图每一块的信息显示在什么地方
            ct.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ct.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            //柱状图其他设置
            ct.Series[0]["DrawingStyle"] = "Cylinder";   //设置柱状平面形状
            ct.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
        }
    }
}
