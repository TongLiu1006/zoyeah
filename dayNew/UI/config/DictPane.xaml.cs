using SmartDetection.biz;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartDetection.UI.config
{
    /// <summary>
    /// DictPane.xaml 的交互逻辑
    /// </summary>
    public partial class DictPane : UserControl
    {
        List<LineType> lineTypes = new List<LineType>();
        public DictPane()
        {
            InitializeComponent();
            InitLineTypes();
            LineTypeData.ItemsSource = lineTypes;
        }
        public List<LineType> InitLineTypes() {
            lineTypes.Add(new LineType("单线", "0"));
            lineTypes.Add(new LineType("双线", "1"));
            lineTypes.Add(new LineType("二线", "2"));
            lineTypes.Add(new LineType("三线", "3"));
            lineTypes.Add(new LineType("四线", "4"));
            lineTypes.Add(new LineType("五线", "5"));
            lineTypes.Add(new LineType("六线", "6"));
            lineTypes.Add(new LineType("七线", "7"));
            lineTypes.Add(new LineType("八线", "8"));
            lineTypes.Add(new LineType("九线", "9"));
           
            return lineTypes;
        }
    }
}
