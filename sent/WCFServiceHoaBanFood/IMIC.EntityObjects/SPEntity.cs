using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.EntityObjects
{
    public class SPEntity
    {
            public string MASP { get; set; }
            public string MADMSP { get; set; }
            public string TENSP { get; set; }
            public decimal GIA { get; set; }

            public byte[] ANHLONSP { get; set; }
            public string DONVISP { get; set; }

            public int SOLUONG { get; set; }

            public int LUOTVIEW { get; set; }
            public int LUOTTHICH { get; set; }

            public string THONGTIN { get; set; }

            public string THONGBAO { get; set; }

            public bool ISPENDING { get; set; }

            public bool ISPUBLISH { get; set; }

            public bool ISDELETE { get; set; }
    }
}
