using SmartDetection.UI.config;
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
    /// SystemSet.xaml 的交互逻辑
    /// </summary>
    public partial class SystemSetPane : UserControl
    {
        public SystemSetPane()
        {
            InitializeComponent();
        }

        private void ConfigButton(object sender, MouseButtonEventArgs e)
        {
            centPane.Children.Clear();
            centPane.Children.Add(new serverPane());

            centPane.UpdateLayout();
        }

        private void lineButClick(object sender, MouseButtonEventArgs e)
        {
            centPane.Children.Clear();
            centPane.Children.Add(new LineWindow());

            centPane.UpdateLayout();
        }

        private void CurveButClick(object sender, MouseButtonEventArgs e)
        {
            centPane.Children.Clear();
            centPane.Children.Add(new CurvePane());

            centPane.UpdateLayout();
        }

        private void DictButClick(object sender, MouseButtonEventArgs e)
        {
            centPane.Children.Clear();
            centPane.Children.Add(new DictPane());

            centPane.UpdateLayout();
        }

        private void RoleButClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ModelButClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
