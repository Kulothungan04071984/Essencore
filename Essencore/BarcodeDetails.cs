using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Essencore
{
    class BarcodeDetails
    {
        //  public int barcodeid { get; set; }
         public string SyrmaSGSPartno { get; set; }
         public string WorkOrderNo { get; set; }
          public string CustomerPartNo { get; set; }
         public string Bar_Description { get; set; }
        public string ProductNo { get; set; }
        public string CustomerSerialNo { get; set; }
        public string PCBSerialNo { get; set; }
        //public string DateandTime { get; set; }
        //public string ShiftType { get; set; }
        public int WeekDetails { get; set; }
        //public string Dublicate { get; set; }
        

    }
}
