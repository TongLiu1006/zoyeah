using SmartDetection.UI;
using SmartDetection.Utils;
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

namespace SmartDetection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseWindow
    {
        //ScanPane scanPane = new ScanPane();
        //MonitorPane monitorPane = new MonitorPane();
        //QueryPane queryPane = new QueryPane();
        //ClientPane clientPane = new ClientPane();
        SystemSetPane setPane = new SystemSetPane();
        //TaskPane taskPane = new TaskPane();
        //EqmPane eqmPane = new EqmPane();
        AppTools appTools;
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            appTools = AppTools.GetInstance();
            appTools.mWindow = this;
        }

        private void Min_ButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void set_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void set_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Close_ButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Max_ButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.MaxHeight = SystemParameters.PrimaryScreenHeight;
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void OnScan(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            // contentPane.Children.Add(scanPane);
        }

        private void OnMoniter(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            contentPane.Children.Add(new DataPlayPane());
        }

        private void OnQuery(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            //contentPane.Children.Add(queryPane);
        }

        private void OnClient(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            //contentPane.Children.Add(clientPane);
        }

        private void OnConfig(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            contentPane.Children.Add(setPane);
        }

        private void OnEquipment(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            //contentPane.Children.Add(eqmPane);
        }

        private void OnTask(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            contentPane.Children.Add(new MyTaskPane());
        }

        private void OnImport(object sender, RoutedEventArgs e)
        {
            contentPane.Children.Clear();
            contentPane.Children.Add(new ImportPlanPane());
        }
    }
}
