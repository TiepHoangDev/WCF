using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class CTDHModel : BaseModel<CTDHEntity>
    {
        private DB_HOABANFOOD_VER2Entities dbContext = null;
        public override List<CTDHEntity> getElements()
        {
          
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            //Tạo list danh sách chứa đối tượng trả về
            List<CTDHEntity> lisCTDHs = new List<CTDHEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_CTDH().ToList();

            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                CTDHEntity objCTDH = new CTDHEntity
                {
                    MADH = "" + objEntity.MADH,
                    MASP = "" + objEntity.MASP,
                    SOLUONG = (int)objEntity.SOLUONG


                };
                lisCTDHs.Add(objCTDH);
            }
            return lisCTDHs;
        }



        public override CTDHEntity findElementById(string sValue)
        {
            throw new NotImplementedException();
        }
    }
}
