using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.Models.DataModel;
using IMIC.EntityObjects;

namespace IMIC.Models
{
    public class LoaiNhanVienModel : BaseModel<LoaiNhanVienEntity>
    {
        private DB_HOABANFOOD_VER2Entities dbContext = null;
        public override List<LoaiNhanVienEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            List<LoaiNhanVienEntity> lisLoaiNV = new List<LoaiNhanVienEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_LOAINHANVIEN().ToList();
            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                LoaiNhanVienEntity objLoaiNhanVien = new LoaiNhanVienEntity
                {
                    MALOAINV = (int)objEntity.MALOAINV,
                    TENLOAINV = "" + objEntity.TENLOAINV
                };
                lisLoaiNV.Add(objLoaiNhanVien);
            }
            return lisLoaiNV;
        }

        public override LoaiNhanVienEntity findElementById(string sValue)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            var objEntity = dbContext.SP_GET_LOAINHANVIEN_BY_ID(int.Parse(sValue)).FirstOrDefault();
            LoaiNhanVienEntity objLoaiNV = new LoaiNhanVienEntity
            {
                MALOAINV = (int)objEntity.MALOAINV,
                TENLOAINV = "" + objEntity.TENLOAINV
            };
            return objLoaiNV;
        }
    }
}
