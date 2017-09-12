using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class LoaiKmModel : BaseModel<LoaiKmEntity>
    {
        private DB_HOABANFOOD_VER2Entities dbContext = null;
        //override hàm getElement

        public override List<LoaiKmEntity> getElements()
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            //Tạo list danh sách chứa đối tượng trả về
            List<LoaiKmEntity> lisLoaiKM = new List<LoaiKmEntity>();
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
            var lisO = dbContext.SP_GET_ALL_KHUYENMAI().ToList();
            //Duyệt rồi add vào lisDMSP;
            foreach (var objEntity in lisO)
            {
                LoaiKmEntity objKM = new LoaiKmEntity
                {
                    MALOAIKM = (int)objEntity.MALOAIKM,
                    TENLOAIKM = "" + objEntity.TENLOAIKM,
                };
                lisLoaiKM.Add(objKM);
            }
            return lisLoaiKM;
        }

      
       public override LoaiKmEntity findElementById(String sValue)
        {
            if (dbContext == null)
               dbContext = new DB_HOABANFOOD_VER2Entities();
            //Tạo list danh sách chứa đối tượng trả về
            int i = int.Parse(sValue);
            //Tạo lisO chứa list Entity khi thực thi StroreProcedure
           var objEntity = dbContext.SP_ALL_LOAIKM_BY_ID(int.Parse(sValue)).FirstOrDefault();
            //Duyệt rồi add vào lisDMSP;   
                       
               LoaiKmEntity objKM = new LoaiKmEntity
                {
                    MALOAIKM = (int)objEntity.MALOAIKM,
                    TENLOAIKM = "" + objEntity.TENLOAIKM,
               };
           return objKM;
              
           }
        
    }
}
