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
    public partial class LineWindow : UserControl
    {
        List<string[]> Lines = null;
        int updown= 1;
        int DIRTO = 1;
        Dictionary<string, string> keyValues = new Dictionary<string, string>();
        public int selectIndex = 0;
        public int lineNo = 0;
        public int lineType = 0;
        public int stationNo = 0;
        public LineWindow()
        {
         
            InitializeComponent();
           
        }
      

       
      
      
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
      
        private void CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
           
           

        }

        private void BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }

        private void LineData_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        
        }

       
    }
}
