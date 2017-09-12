using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class ThichSPModel : BaseModel<ThichSPEntity>
    {
        private DB_HOABANFOOD_VER2Entities dbContext = null;
        public override List<ThichSPEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            List<ThichSPEntity> lisAllThichSP = new List<ThichSPEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_THICHSANPHAM().ToList();
            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                ThichSPEntity objAlThich = new ThichSPEntity
                {
                    MASP = "" + objEntity.MASP,
                    MANV = "" + objEntity.MANV
                };
                lisAllThichSP.Add(objAlThich);
            }

            return lisAllThichSP;
        }

        public List<ThichSPEntity> getElementsNvThich(string sMANV)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            List<ThichSPEntity> lisAllNvThich = new List<ThichSPEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_SP_NHANVIEN_THICH(sMANV).ToList();
            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                ThichSPEntity objAlThich = new ThichSPEntity
                {
                    MASP = "" + objEntity.MASP,
                    MANV = "" + objEntity.MANV
                };
                lisAllNvThich.Add(objAlThich);
            }

            return lisAllNvThich;
        }

        public List<ThichSPEntity> getElementSPDuocThich(string sMASP)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();

            List<ThichSPEntity> lisAllSPDuocThich = new List<ThichSPEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_SP_NHANVIEN_THICH(sMASP).ToList();
            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                ThichSPEntity objAlThich = new ThichSPEntity
                {
                    MASP = "" + objEntity.MASP,
                    MANV = "" + objEntity.MANV
                };
                lisAllSPDuocThich.Add(objAlThich);
            }

            return lisAllSPDuocThich;
        }
        public override ThichSPEntity findElementById(string sValue)
        {
            throw new NotImplementedException();
        }
    }
}
