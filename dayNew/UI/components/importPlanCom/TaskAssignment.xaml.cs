using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SmartDetection.UI.components.importPlanCom
{
    /// <summary>
    /// TaskAssignment.xaml 的交互逻辑
    /// </summary>
    public partial class TaskAssignment : UserControl
    {

        private ObservableCollection<PlayBackPersonRow> personList;

        public TaskAssignment()
        {
            InitializeComponent();



            personList = new ObservableCollection<PlayBackPersonRow>();

            personList.Add(new PlayBackPersonRow() { name = "1" });
            personList.Add(new PlayBackPersonRow() { name = "2" });
            personList.Add(new PlayBackPersonRow() { name = "3" });
            personList.Add(new PlayBackPersonRow() { name = "4" });

            PlayBackPerson.ItemsSource = personList;
        }

        public class PlayBackPersonRow
        {
            public string name { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            personList.Add(new PlayBackPersonRow() { name = "4" });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(personList[3].name);
        }
    }
}
