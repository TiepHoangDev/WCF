using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.EntityObjects
{
    public class ANHSPEntity
    {
        public string MAANH { get; set; }
        public string MASP { get; set; }
        public string URL { get; set; }
        public byte[] ANHSP { get; set; }
        public bool ISPENDING { get; set; }
        public bool ISPUBLISH { get; set; }
        public bool ISDELETE { get; set; }
    }
}
