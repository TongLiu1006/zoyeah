using SmartDetection.UI.components.importPlanCom;
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

namespace SmartDetection.UI.components.myTaskPane
{
    /// <summary>
    /// LedgerInformation.xaml 的交互逻辑
    /// </summary>
    public partial class LedgerInformation : UserControl
    {

        public class listRow
        {
            public string time { get; set; }

        }

        public LedgerInformation()
        {
            InitializeComponent();

            List<listRow> listRows = new List<listRow>();
            listRows.Add(new listRow() { time = "2023-01-03" });

            dataGrid_dataList.ItemsSource = listRows;
        }

        private void click_detail(object sender, RoutedEventArgs e)
        {
            try
            {
                LedgerLise.Children.Clear();
                LedgerLise.Children.Add(new detailPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
