using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDetection.biz
{
    public class CurveInfo
    {
        public string id { set; get; }
        public string lineNo { set; get; }
        public string lineName { set; get; }
        public string startMileage { set; get; }
        public string endMileage { set; get; }
        public string rowType { set; get; }
        public string curveDirection { set; get; }
        public string curveRadius { set; get; }
        public int curveLength { set; get; }
        public int isDelete { set;get; }

        public int speedLimit { set; get; } 
        public string mySpeed { set; get; }
   
      
    }
}
