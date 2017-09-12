using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class ANHSPModel : BaseModel<ANHSPEntity>
    {
        DB_HOABANFOOD_VER2Entities dbContext;

        public override List<ANHSPEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            List<ANHSPEntity> lisANH = new List<ANHSPEntity>();
            var lis0 = dbContext.SP_GET_ALL_ANH().ToList();
            foreach (var objEntity in lis0)
            {
                ANHSPEntity objANH = new ANHSPEntity
                { MAANH = ""+objEntity.MAANH,
                    MASP = ""+objEntity.MASP,
                    URL = objEntity.URL,
                    ANHSP = objEntity.ANHSP,
                    ISPENDING = (bool) objEntity.ISPENDING,
                  ISPUBLISH = (bool)objEntity.ISPUBLISH,
                  ISDELETE = (bool)objEntity.ISDELETE
                };
                lisANH.Add(objANH);
            }
            return lisANH;
        }

        public List<ANHSPEntity> getAllAnhBySP(String MASP)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            List<ANHSPEntity> lisANH = new List<ANHSPEntity>();
            var lis0 = dbContext.SP_GET_ALL_ANH_SP_BY_ID(MASP).ToList();
            foreach (var objEntity in lis0)
            {
                ANHSPEntity objANH = new ANHSPEntity
                {
                    MAANH = "" + objEntity.MAANH,
                    MASP = "" + objEntity.MASP,
                    URL = objEntity.URL,
                    ANHSP = objEntity.ANHSP,
                    ISPENDING = (bool)objEntity.ISPENDING,
                    ISPUBLISH = (bool)objEntity.ISPUBLISH,
                    ISDELETE = (bool)objEntity.ISDELETE
                };
                lisANH.Add(objANH);
            }
            return lisANH;
        }


        public override ANHSPEntity findElementById(string sValue)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            var objEntity = dbContext.SP_GET_ALL_ANH_SP_BY_ID(sValue).FirstOrDefault();
            ANHSPEntity objANH = new ANHSPEntity
            {
                MAANH = "" + objEntity.MAANH,
                MASP = "" + objEntity.MASP,
                URL = objEntity.URL,
                ANHSP = objEntity.ANHSP,
                ISPENDING = (bool)objEntity.ISPENDING,
                ISPUBLISH = (bool)objEntity.ISPUBLISH,
                ISDELETE = (bool)objEntity.ISDELETE
            };

            return objANH;
        }

    }
}
