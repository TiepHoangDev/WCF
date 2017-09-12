using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;


namespace IMIC.Models
{
    public class SPModel : BaseModel<SPEntity>
    {
        
        private DB_HOABANFOOD_VER2Entities dbContext;

        public override List<SPEntity> getElements()
        {
            if (dbContext == null)
            {
                dbContext = new DB_HOABANFOOD_VER2Entities();
            }
            List<SPEntity> lisSP = new List<SPEntity>();
            var lis0 = dbContext.SP_GET_ALL_SANPHAM().ToList();

            foreach (var objEntity in lis0)
            {
                SPEntity objSP = new SPEntity
                {
                    MASP = "" + objEntity.MASP,
                    MADMSP = "" + objEntity.MADMSP,
                    TENSP = "" +  objEntity.TENSP,
                    GIA = (decimal)objEntity.GIA,
                    ANHLONSP = objEntity.ANHLONSP,
                    DONVISP = ""+objEntity.DONVISP,
                    SOLUONG = (int)objEntity.SOLUONG,
                    LUOTVIEW = (int)objEntity.LUOTVIEW,
                    LUOTTHICH = (int)objEntity.LUOTTHICH,
                    THONGTIN =""+ objEntity.THONGTIN,
                    THONGBAO =""+ objEntity.THONGBAO,
                    ISPENDING = (bool)objEntity.ISPENDING,
                    ISPUBLISH = (bool)objEntity.ISPUBLISH,
                    ISDELETE = (bool)objEntity.ISDELETE
                };
                lisSP.Add(objSP);
            }
            return lisSP;
        }

        public List<SPEntity> findAllElementByMADMSP(string sMADMSP)
        {
            if (dbContext == null)
            {
                dbContext = new DB_HOABANFOOD_VER2Entities();
            }
            List<SPEntity> lisSP = new List<SPEntity>();
            var lis0 = dbContext.SP_GET_ALL_SP_DMSP_BY_ID(sMADMSP).ToList();

            foreach (var objEntity in lis0)
            {
                SPEntity objSP = new SPEntity
                {
                    MASP = "" + objEntity.MASP,
                    MADMSP = "" + objEntity.MADMSP,
                    TENSP = ""+objEntity.TENSP,
                    GIA = (decimal)objEntity.GIA,
                    ANHLONSP = objEntity.ANHLONSP,
                    DONVISP = ""+objEntity.DONVISP,
                    SOLUONG = (int)objEntity.SOLUONG,
                    LUOTVIEW = (int)objEntity.LUOTVIEW,
                    LUOTTHICH = (int)objEntity.LUOTTHICH,
                    THONGTIN =""+ objEntity.THONGTIN,
                    THONGBAO = ""+objEntity.THONGBAO,
                    ISPENDING = (bool)objEntity.ISPENDING,
                    ISPUBLISH = (bool)objEntity.ISPUBLISH,
                    ISDELETE = (bool)objEntity.ISDELETE
                };
                lisSP.Add(objSP);
            }
            return lisSP;
        }
        public override SPEntity findElementById(string sValue)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            var objEntity = dbContext.SP_GET_SANPHAM_BY_ID(sValue).FirstOrDefault();

            SPEntity objSP = new SPEntity
            {
                MASP = "" + objEntity.MASP,
                MADMSP = "" + objEntity.MADMSP,
                TENSP = ""+objEntity.TENSP,
                GIA = (decimal)objEntity.GIA,
                ANHLONSP = objEntity.ANHLONSP,
                DONVISP = ""+objEntity.DONVISP,
                SOLUONG = (int)objEntity.SOLUONG,
                LUOTVIEW = (int)objEntity.LUOTVIEW,
                LUOTTHICH = (int)objEntity.LUOTTHICH,
                THONGTIN = ""+objEntity.THONGTIN,
                THONGBAO = ""+objEntity.THONGBAO,
                ISPENDING = (bool)objEntity.ISPENDING,
                ISPUBLISH = (bool)objEntity.ISPUBLISH,
                ISDELETE = (bool)objEntity.ISDELETE
            };

            return objSP;
        }
    }
}
