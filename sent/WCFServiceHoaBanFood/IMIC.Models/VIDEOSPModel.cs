using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class VIDEOSPModel : BaseModel<VIDEOSPEntity>
    {
        DB_HOABANFOOD_VER2Entities dbContext;
        public override VIDEOSPEntity findElementById(string sValue)
        {
            throw new NotImplementedException();
        }

        public override List<VIDEOSPEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            List<VIDEOSPEntity> lisVIDEO = new List<VIDEOSPEntity>();
            var lis0 = dbContext.SP_GET_ALL_VIDEO().ToList();
            foreach (var objEntity in lis0)
            {
                VIDEOSPEntity objVIDEO = new VIDEOSPEntity
                {
                    MAVD =""+ objEntity.MAVD,
                    MASP =""+ objEntity.MASP,
                    URL = objEntity.URL,
                    ISPENDING = (bool) objEntity.ISPENDING,
                    ISPUBLISH = (bool)objEntity.ISPENDING,
                    ISDELETE = (bool)objEntity.ISDELETE
                };
                lisVIDEO.Add(objVIDEO);
            }
            return lisVIDEO;
        }

        public VIDEOSPEntity findElementByMaSP(string sMASP)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            var objEntity = dbContext.SP_GET_ALL_VD_SP_BY_ID(sMASP).FirstOrDefault();

            VIDEOSPEntity objVIDEO = new VIDEOSPEntity
            {
                MAVD = "" + objEntity.MAVD,
                MASP = "" + objEntity.MASP,
                URL = objEntity.URL,
                ISPENDING = (bool)objEntity.ISPENDING,
                ISPUBLISH = (bool)objEntity.ISPENDING,
                ISDELETE = (bool)objEntity.ISDELETE
            };

            return objVIDEO;
        }
    }
}
