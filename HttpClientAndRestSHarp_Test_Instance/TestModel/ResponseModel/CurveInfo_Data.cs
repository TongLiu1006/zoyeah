using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAndRestSHarp_Test_Instance.TestModel.ResponseModel
{
    public class CurveInfo_Data
    {
        public int code { get; set; }
        public CurveInfo[] data { get; set; }
        public string msg { get; set; }

    }

    public class CurveInfo
    {
        public string curveDirection { get; set; }
        public double curveLength { get; set; }
        public double curveRadius { get; set; }
        public double endMileage { get; set; }
        public string lineName { get; set; }
        public string remark { get; set; }
        public string rowType { get; set; }
        public string speedLimit { get; set; }
        public double startMileage { get; set; }

    }

}
