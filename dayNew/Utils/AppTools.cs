
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SmartDetection.Utils
{
    public class AppTools
    {
        private static AppTools instance = null;
        private string web_base = "http://47.122.7.96";
        private string web_config = "/minor-radius-curve/curve/";
        public  MainWindow mWindow;
        private AppTools()
        {

        }
        public static AppTools GetInstance()
        {
            if (instance == null)
            {
                instance = new AppTools();
               
            }
            return instance;
        }
   

        public static string rootPath = AppDomain.CurrentDomain.BaseDirectory;
     
    

        public Border PolygonConfirmBorder;

      //  public MenuBar_CustomControl MenuBarControl;

       
    
    }
}
