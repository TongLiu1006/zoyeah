
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
        public static int CursorsWidth = 60;
        public static int CursorsHeight = 90;
        public static int penWidth = 4;
        public static int penHeight = 4;
        public static bool PolygonConfirm = false;
        public static bool IsClone = false;
        public  MainWindow mWindow;
        private AppTools()
        {

        }
        public static AppTools GetInstance()
        {
            if (instance == null)
            {
                instance = new AppTools();
                instance.BrushColor = Colors.Red;
                instance.alpha = 1;
            }
            return instance;
        }
        public double SWidth { set; get; }
        public double SHeight { set; get; }

        public static string AppID = "23104314";
        public static string APIKEY = "TqL74NFULDGTK9eLGPCqGxAN";
        public static string SecretKey = "id2KmD74986HPzAeW9rnw6CAABf5Zttr";

        public static string rootPath = AppDomain.CurrentDomain.BaseDirectory;
        public Grid gridMainWin;
        public bool isMenuBarClick = false;
        public bool isSaveClick = false;

    

        public Border PolygonConfirmBorder;

      //  public MenuBar_CustomControl MenuBarControl;

       
        public MainWindow OwnerWindow { set; get; }
        public int CursorSize { set; get; }
        public string openFile { set; get; }
        public double ScreenWidth { set; get; }
        public double ScreenHeight { set; get; }

        /**
         *   0=小黑板檫 1=大的
         */
        public int EraserSize { set; get; }
        public System.Windows.Media.Color BrushColor { set; get; }

        public double ScaleMax;
        public double CurrentScale;

        /// <summary>
        /// 根据文本布局设置缩放比例反比例缩小
        /// </summary>
        public ScaleTransform scaleTransformNarrow;

        /// <summary>
        ///根据文本布局设置缩放比例同比例放大
        /// </summary>
        public ScaleTransform scaleTransformEnlarge;
        public double alpha { set; get; }
        /**
         * 形状分类
         */
        public int Model { set; get; }
        /**
         *  0=画笔  1=自定义图形
         */
        public int DrawModel { set; get; }
       // public KeyboardWin KeyboardWindow;
        public static System.Windows.Media.Color StringToColor(string colorStr)//传入string，得到Color
        {
            Byte[] argb = new Byte[4];
            for (int i = 0; i < 4; i++)
            {
                char[] charArray = colorStr.Substring(i * 2, 2).ToCharArray();
                //string str = "11";
                Byte b1 = toByte(charArray[0]);
                Byte b2 = toByte(charArray[1]);
                argb[i] = (Byte)(b2 | (b1 << 4));
            }
            return System.Windows.Media.Color.FromArgb(argb[0], argb[1], argb[2], argb[3]);//#FFFFFFFF
        }
        private static byte toByte(char c)
        {
            byte b = (byte)"0123456789ABCDEF".IndexOf(c);
            return b;
        }
     
    }
}
