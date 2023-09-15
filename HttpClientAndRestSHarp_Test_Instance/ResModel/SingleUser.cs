using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAndRestSHarp_Test_Instance.ResModel
{
    [ObservableObject]
    public partial class SingleUser 
    {
     
        [ObservableProperty]
        private Data _data;

        public Data data
        {
            get { return _data; }
            set => SetProperty(ref _data, value);
           
        }

        [ObservableProperty]
        private Support _support;
        public Support support
        {
            get { return _support; }
            set=> SetProperty(ref _support, value);
        }

       
  
    }

    [ObservableObject]
    public partial class Data 
    {
        [ObservableProperty]
        private int _id;
        public int id
        {
            get { return _id; }
            set => SetProperty(ref _id,value);
        }
        [ObservableProperty]
        private string _last_name;

        public string last_name
        {
            get { return _last_name; }
            set => SetProperty(ref _last_name,value);
        }

        public string email { get; set; }
        public string first_name { get; set; }
     
        public string avatar { get; set; }
    }

}
