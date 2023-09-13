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

namespace SmartDetection.UI.components.importPlanCom
{
    /// <summary>
    /// PlannedTaskList.xaml 的交互逻辑
    /// </summary>
    public partial class PlannedTaskList : UserControl
    {
        public PlannedTaskList()
        {
            InitializeComponent();
            List<TaskRow> taskRows = new List<TaskRow>();
            for (int i = 0; i < 10; i++) { 
                TaskRow taskRow = new TaskRow();
                taskRow.workDate = "2023";
                taskRows.Add(taskRow);
            }
            PlaneTaskList.ItemsSource = taskRows;


        }
        public class TaskRow { 
            public string workDate { get; set; }
        
        }
    }
}
