using System;
using System.Collections.Generic;
using System.IO;
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

namespace TreeViewsAndValueConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region constructor
        public MainWindow()
        {
            InitializeComponent();

            //var t=new TreeViewItem();
            //t.HeaderTemplate
        }
        #endregion constructor

        #region onload
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //get every logical drive in machine
            foreach (var drive in Directory.GetLogicalDrives())
            {
                //create a treeview
                var item = new TreeViewItem();
                item.Tag = drive;
                item.Header = drive;

                item.Items.Add(null);

                //listen out for item being expanded
                item.Expanded += Folder_Expander;
                FolderView.Items.Add(item);
            }


        }
        #endregion


        #region folder expander
        /// <summary>
        /// when you want expand ,you will get sub file/folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Folder_Expander(object sender, RoutedEventArgs e)
        {
            #region initial check
            var item = (TreeViewItem)sender;
            if (item.Items.Count != 1 || item.Items[0] != null) return;

            //clean dummy data
            item.Items.Clear();

            #endregion

            #region get folders
            //Get full path
            var fullpath = (string)item.Tag;

            //create a blank directors for list
            List<string> directors = new List<string>();


            // try and get directories from folder
            //ingore any issues doing so
            try
            {

                var dirs = Directory.GetDirectories(fullpath);
                if (dirs.Length > 0)
                    directors.AddRange(dirs);

            }
            catch (Exception)
            {

                throw;
            }

            //for each directory
            directors.ForEach(directorpath =>
            {

                //create director item
                var subitem = new TreeViewItem()
                {
                    //set header as folder name
                    Header = GetFolderName(directorpath),
                    //add tag as fullpath
                    Tag = directorpath
                };

                //add dummy item so we can expand folder
                subitem.Items.Add(null);

                //handle expading
                subitem.Expanded += Folder_Expander;

                //add this item to parent
                item.Items.Add(subitem);
            });
            #endregion
            #region get files
            //create a blank files for list
            List<string> files = new List<string>();


            // try and get files from folder
            //ingore any issues doing so
            try
            {

                var fs = Directory.GetFiles(fullpath);
                if (fs.Length > 0)
                    files.AddRange(fs);

            }
            catch (Exception)
            {

                throw;
            }

            //for each fs
            files.ForEach(fpath =>
            {

                //create director item
                var subitem = new TreeViewItem()
                {
                    //set header as folder name
                    Header = GetFolderName(fpath),
                    //add tag as fullpath
                    Tag = fpath
                };

                //add dummy item so we can expand folder
                //item.Items.Add(null);

                //handle expading
                //subitem.Expanded += Folder_Expander;

                //add this item to parent
                item.Items.Add(subitem);
            });
            #endregion


        }


        #endregion

        #region Hepler
        /// <summary>
        /// get folder name 
        /// </summary>
        /// <param name="directorpath"></param>
        /// <returns></returns>
        public static string GetFolderName(string directorpath)
        {
            //if we have no path ,return empty
            if (string.IsNullOrEmpty(directorpath))
                return string.Empty;

            //make all slashes back slashes
            var normalizedPath=directorpath.Replace( "/","\\");

            //find the last  backslash in the path
            var lastIndex=normalizedPath.LastIndexOf("\\");

            //if we dont find a backslash ,return the path itself
            if (lastIndex <= 0) return directorpath;

            return directorpath.Substring(lastIndex+1);


        }
        #endregion
    }
}
