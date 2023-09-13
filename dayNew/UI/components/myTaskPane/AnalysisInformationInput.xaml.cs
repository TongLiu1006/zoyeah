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
    /// AnalysisInformationInput.xaml 的交互逻辑
    /// </summary>
    public partial class AnalysisInformationInput : UserControl
    {
        public class inputRow
        {
            public int number { get; set; }
        }

        public AnalysisInformationInput()
        {
            InitializeComponent();
            List<inputRow> inputRows = new List<inputRow>();
            inputRows.Add(new inputRow() { number = 001 });

            inputTable.ItemsSource = inputRows;

        }

        private void Alarm_Input(object sender, RoutedEventArgs e)
        {
            try
            {
                AlarmInputList.Children.Clear();
                AlarmInputList.Children.Add(new taskAlarmInput());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void click_ledgerInformation(object sender, RoutedEventArgs e)
        {
            try
            {
                AlarmInputList.Children.Clear();
                AlarmInputList.Children.Add(new LedgerInformation());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
