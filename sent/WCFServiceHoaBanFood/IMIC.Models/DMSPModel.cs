using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;
namespace IMIC.Models
{
    public class DMSPModel : BaseModel<DMSPEntity>
    {
        //Khởi tao  đối tượng kết nối ADO.Net Entity DataModel
        private DB_HOABANFOOD_VER2Entities dbContext = null;
        //override hàm getElement
        public override List<DMSPEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            //Tạo list danh sách chứa đối tượng trả về
            List<DMSPEntity> lisDMSPs = new List<DMSPEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_DMSP().ToList();
            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                DMSPEntity objDMSP = new DMSPEntity
                {
                    MADMSP = ""+objEntity.MADMSP,
                    TENDMSP = ""+objEntity.TENDMSP,
                    ANHDMSP = (byte[])objEntity.ANHDMSP,
                    ISDELETE = (bool)objEntity.ISDELETE
                };
                lisDMSPs.Add(objDMSP);
            }
            return lisDMSPs;
        }

        public override DMSPEntity findElementById(string sValue)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            //sValue = "332fc98f-d777-4e13-b13d-bc37afc280d8";
            var objEntity = dbContext.SP_GET_DMSP_BY_ID(sValue).FirstOrDefault();
            DMSPEntity objDMSP= new DMSPEntity
            {
                MADMSP = "" + objEntity.MADMSP,
                TENDMSP = "" + objEntity.TENDMSP,
                ANHDMSP = (byte[])objEntity.ANHDMSP,
                ISDELETE = (bool)objEntity.ISDELETE
            };
            return objDMSP;
        }
    }
}
