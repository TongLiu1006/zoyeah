using SmartDetection.UI.components.importPlanCom;
using SmartDetection.UI.components.myTaskPane;
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

namespace SmartDetection.UI
{
    /// <summary>
    /// ImportPlanPane.xaml 的交互逻辑
    /// </summary>
    public partial class MyTaskPane : UserControl
    {
        public class TaskRow
        {
            public int id { get; set; }

        }

        public MyTaskPane()
        {
            InitializeComponent();

            List<TaskRow> tasks = new List<TaskRow>();
            tasks.Add(new TaskRow() { id = 123 });

            StationData.ItemsSource = tasks;
            StationData_Claimed.ItemsSource = tasks;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void importPlan(object sender, RoutedEventArgs e)
        {

        }

        private void queryPlan(object sender, RoutedEventArgs e)
        {

        }

        private void CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }

        private void TabSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void click_claimPage(object sender, RoutedEventArgs e)
        {
            try
            {
                myTaskPane.Children.Clear();
                myTaskPane.Children.Add(new ClaimPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void click_Analysis_Information_Input(object sender, RoutedEventArgs e)
        {
            try
            {
                myTaskPane.Children.Clear();
                myTaskPane.Children.Add(new AnalysisInformationInput());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
