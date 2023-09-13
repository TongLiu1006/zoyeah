using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDetection.biz
{
   public class LineInfo:ViewModelBase
    {
        public int ids;
        public int Id { set
            {
                ids = value;
                RaisePropertyChanged(nameof(Id));
            }get {

                return ids;
            } }
        private int lNo;
        public int LineNo { set {
                lNo = value;
                RaisePropertyChanged(nameof(LineNo));
            } get {
                return lNo;
            } }
        private string lname;
        public string LineName { set {
                lname = value;
                RaisePropertyChanged(nameof(LineName));
            } get {
                return lname;
            } }
        private string fArea;
        public string FromArea { set {

                fArea = value;
                RaisePropertyChanged(nameof(FromArea));
            }
            get
            {
                return fArea;
            }
        }
        private string tArea;
        public string ToArea {
            set
            {

                tArea = value;
                RaisePropertyChanged(nameof(ToArea));
            }
            get
            {
                return tArea;
            }
        }
        private int ud;
        public int UpDown {
            set
            {

                ud = value;
                RaisePropertyChanged(nameof(UpDown));
            }
            get
            {
                return ud;
            }
        }
        private int kDir;
        public int KilloDir
        {
            set
            {

                kDir = value;
                RaisePropertyChanged(nameof(KilloDir));
            }
            get
            {
                return kDir;
            }
        }
        private int fKillo;
        public int FromKillo {
            set
            {
                fKillo = value;
                RaisePropertyChanged(nameof(FromKillo));
            }
            get
            {
                return fKillo;
            }
        }
        private int tKillo;
        public int ToKillo
        {
            set
            {
                tKillo = value;
                RaisePropertyChanged(nameof(ToKillo));
            }
            get
            {
                return tKillo;
            }
        }
        private int lType;
        public int LineType {
            set
            {
                lType = value;
                RaisePropertyChanged(nameof(LineType));
            }
            get
            {
                return lType;
            }
        }
        private int eKillo;
        public int EndKillo
        {
            set
            {
                eKillo = value;
                RaisePropertyChanged(nameof(EndKillo));
            }
            get
            {
                return eKillo;
            }
        }
        public string TString;
        public  string ToString
        {
            set { TString = value; RaisePropertyChanged(ToString); }
            get {
                string lx = "";
            string addSub = "递增";
            string ud = "上行";
            if (UpDown == 0) ud = "下行";
            
            if(KilloDir==0)
                    addSub = "递减";
            if (LineType == 2) 
                    lx = "二";
            if (LineType == 3)
                    lx = "三";
            if (LineType == 4)
                    lx = "四";
            if (LineType == 5)
                    lx = "五";
                if (LineType == 9)
                    lx = "单";
                if (LineType == 10)
                    lx = "双";
             return LineName + lx+"[" + FromArea + "-" + ToArea + "-"+ud+ "-" + addSub + "]";
            }
        }
        public string ToUpdateSql()
        {
            return "update lineinfo set fromarea='" + FromArea + "',toarea='"+ToArea+"', fromkillo=" + FromKillo + ",tokillo="+ToKillo+", updown=" + UpDown +" ,killodir=" + KilloDir +",linetype="+LineType+
                " where id=" + Id;
        }

    }
}
