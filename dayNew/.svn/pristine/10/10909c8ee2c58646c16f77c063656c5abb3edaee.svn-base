
using SmartDetection.biz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SmartDetection.UI.config
{
    /// <summary>
    /// LineBrokenWindows.xaml 的交互逻辑
    /// </summary>
    public partial class CurvePane : UserControl
    {
        List<string[]> Lines = null;
      
        List< LineInfo> LineInfos = new List< LineInfo>();

        Dictionary<string, string> keyValues = new Dictionary<string, string>();
        public int selectIndex = 0;
        public int lineNo = 0;
        public int lineType = 0;
        public CurvePane()
        {
         
            InitializeComponent();
            initLines();
        }
        public void initLines()
        {
            LineInfos.Clear();

            //Lines = SqliteHelper.GetInstance().QueryTable("select id,lineno,linename,fromarea,toarea,updown,killodir,fromkillo,tokillo,linetype from lineinfo");
            //for (int i = 0; i < Lines.Count; i++)
            //{
            //    LineInfo info = new LineInfo();
            //    info.id = Int32.Parse(Lines[i][0]);
            //    info.lineNo = Int32.Parse(Lines[i][1]);
            //    info.lineName = Lines[i][2];
            //    info.fromArea = Lines[i][3];
            //    info.toArea = Lines[i][4];
            //    info.upDown = Int32.Parse(Lines[i][5]);
            //    info.killoDir = Int32.Parse(Lines[i][6]);
            //    info.fromKillo = Int32.Parse(Lines[i][7]);
            //    info.toKillo = Int32.Parse(Lines[i][8]);
            //    info.lineType = Int32.Parse(Lines[i][9]);
                
            //    LineInfos.Add(info);
            //    keyValues.Add(Lines[i][0], info.toString);
            //}
            //lines.ItemsSource = keyValues;
            //lines.DisplayMemberPath = "Value";
            //lines.SelectedValuePath = "Key";
        }

        private void line_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int index= lines.SelectedIndex;

            //lineNo = LineInfos[index].lineNo;
            //updown = LineInfos[index].upDown;
            //lineType = LineInfos[index].lineType;
            //DIRTO = LineInfos[index].killoDir;
            //refreshBridgeData();
            //refreshTunnelData();
            //refreshCurveData();
        }
        public void refreshBridgeData()
        {

           
            
        }
        public void refreshTunnelData()
        {

          

        }
        public void refreshCurveData()
        {
            //string sql = "";
            //List<CurveInfo> dataList = new List<CurveInfo>();
            //if (lineType == 0)
            //{
            //    sql = "select * from curve where lineno=" + lineNo + " and updown =" + updown;
            //}
            //else
            //{
            //    sql = "select * from curve where lineno=" + lineNo + " and updown =" + lineType;

            //}
            //List<string[]> rows = SqliteHelper.GetInstance().QueryTable(sql);
            //for (int i = 0; i < rows.Count; i++)
            //{
            //    CurveInfo curve = new CurveInfo();
            //    //然后给这一行的每一列都赋值
            //    curve.id = rows[i][0];
            //    curve.lineNo = rows[i][1];
            //    curve.updown = rows[i][2];

            //    curve.sPoint = rows[i][3];
            //    curve.ePoint = rows[i][4];
            //    curve.lr = rows[i][5];
            //    curve.radius = rows[i][6];
            //    curve.mySpeed= rows[i][7];
            //    dataList.Add(curve);
            //}

            //CurveData.ItemsSource = dataList;

        }


        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void TabSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
           
        }

        private void CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
           
           
                //CurveInfo eData = (CurveInfo)e.Row.Item;
                //if (eData != null)
                //{
                //    SqliteHelper.GetInstance().ExecuteQuery(eData.toUpdateSql());

                //    //refreshData();
                //}
        }

        private void BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }
    }
}
