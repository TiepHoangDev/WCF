using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class NhanVienModel : BaseModel<NhanVienEntity>
    {
        private DB_HOABANFOOD_VER2Entities dbContext = null;

        public override List<NhanVienEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            List<NhanVienEntity> listNV = new List<NhanVienEntity>();
            var lisO = dbContext.SP_GET_ALL_NHANVIEN().ToList();

            foreach (var objEntity in lisO)
            {
                NhanVienEntity objNhanVien = new NhanVienEntity
                {
                    MANV = "" + objEntity.MANV,
                    TENNV = "" + objEntity.TENNV,
                    TENDN = "" + objEntity.TENDN,
                    MATKHAU = "" + objEntity.MATKHAU,
                    DIACHI = "" + objEntity.DIACHI,
                    NGAYSINH = "" + objEntity.NGAYSINH,
                    SODT = "" + objEntity.SODT,
                    GIOITINH = "" + objEntity.GIOITINH,
                    EMAIL = "" + objEntity.EMAIL,
                    MALOAINV = (int)objEntity.MALOAINV
                };
                listNV.Add(objNhanVien);
            }
            return listNV;
        }

        public override NhanVienEntity findElementById(string sValue)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            var objEntity = dbContext.SP_GET_ALL_NHANVIEN_BY_ID(sValue).FirstOrDefault();
            NhanVienEntity objNV = new NhanVienEntity
            {
                MANV = "" + objEntity.MANV,
                TENNV = "" + objEntity.TENNV,
                TENDN = "" + objEntity.TENDN,
                MATKHAU = "" + objEntity.MATKHAU,
                DIACHI = "" + objEntity.DIACHI,
                NGAYSINH = "" + objEntity.NGAYSINH,
                SODT = "" + objEntity.SODT,
                GIOITINH = "" + objEntity.GIOITINH,
                EMAIL = "" + objEntity.EMAIL,
                MALOAINV = (int)objEntity.MALOAINV
            };

            return objNV;
        }
    }
}
