using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAndRestSHarp_Test_Instance.TestModel.RequestModel
{

    public class LineInfo
    {
        public int code { get; set; }
        public string msg { get; set; }
        public Datum_lineinfo[] data { get; set; }
    }

    public class Datum_lineinfo
    {
        public int lineNo { get; set; }
        public string lineName { get; set; }
    }

}
