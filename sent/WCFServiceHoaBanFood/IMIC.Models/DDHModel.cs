using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class DDHModel : BaseModel<DDHEntity>
    {
        private DB_HOABANFOOD_VER2Entities dbContext = null;
        public override List<DDHEntity> getElements()
        {

            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            //Tạo list danh sách chứa đối tượng trả về
            List<DDHEntity> lisDDHs = new List<DDHEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_DDH().ToList();

            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                DDHEntity objDDH = new DDHEntity
                {
                    MADH = "" + objEntity.MADH,
                    MANV = "" + objEntity.MANV,
                    TRANGTHAI = (int)objEntity.TRANGTHAI,
                    DIACHIGIAO = "" + objEntity.DIACHIGIAO,
                    NGAYDAT = (DateTime)objEntity.NGAYDAT,
                    NGAYGIAO = (DateTime)objEntity.NGAYGIAO,
                    MOTA = "" + objEntity.MOTA

                };
                lisDDHs.Add(objDDH);
            }
            return lisDDHs;
        }

        public override DDHEntity findElementById(string sValue)
        {
            throw new NotImplementedException();
        }
    }
}
