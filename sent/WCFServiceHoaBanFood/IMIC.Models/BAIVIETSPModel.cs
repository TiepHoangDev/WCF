using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class BAIVIETSPModel : BaseModel<BAIVIETSPEntity>
    {
        DB_HOABANFOOD_VER2Entities dbContext;

        public override List<BAIVIETSPEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            List<BAIVIETSPEntity> lisANH = new List<BAIVIETSPEntity>();
            var lis0 = dbContext.SP_GET_ALL_BAIVIET().ToList();
            foreach (var objEntity in lis0)
            {
                BAIVIETSPEntity objBAIVIET = new BAIVIETSPEntity
                {
                    MABV = ""+ objEntity.MABV,
                    MASP = ""+ objEntity.MASP,
                    TIEUDE = objEntity.TIEUDE,
                    NOIDUNG = objEntity.NOIDUNG,
                    ISPENDING = (bool) objEntity.ISPENDING,
                    ISPUBLISH = (bool) objEntity.ISPUBLISH,
                    ISDELETE = (bool) objEntity.ISDELETE
                };
                lisANH.Add(objBAIVIET);
            }
            return lisANH;
        }

        public override BAIVIETSPEntity findElementById(string sValue)
        {
            throw new NotImplementedException();
        }

        public BAIVIETSPEntity findElementByMASP(string sMASP)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            var objEntity = dbContext.SP_GET_ALL_BV_SP_BY_ID(sMASP).FirstOrDefault();

            BAIVIETSPEntity objBAIVIET = new BAIVIETSPEntity
            {
                MABV = "" + objEntity.MABV,
                MASP = "" + objEntity.MASP,
                TIEUDE = objEntity.TIEUDE,
                NOIDUNG = objEntity.NOIDUNG,
                ISPENDING = (bool)objEntity.ISPENDING,
                ISPUBLISH = (bool)objEntity.ISPUBLISH,
                ISDELETE = (bool)objEntity.ISDELETE
            };

            return objBAIVIET;
        }
    }
}
