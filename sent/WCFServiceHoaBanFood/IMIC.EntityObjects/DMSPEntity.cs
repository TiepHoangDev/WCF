using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.EntityObjects
{
    public class DMSPEntity
    {
        public string MADMSP { get; set; }
        public string TENDMSP { get; set; }
        public byte[] ANHDMSP { get; set; }
        public bool ISDELETE { get; set; }
    }
}
