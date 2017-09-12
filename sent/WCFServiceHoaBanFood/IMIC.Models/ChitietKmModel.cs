using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models.DataModel;

namespace IMIC.Models
{
    public class ChitietKmModel :BaseModel<ChitietKmEntity>

    {
        private DB_HOABANFOOD_VER2Entities dbContext = null;

        public override List<ChitietKmEntity> getElements()
        {
            if (dbContext == null)        
                dbContext = new DB_HOABANFOOD_VER2Entities();

                List<ChitietKmEntity> lisLoaiKM = new List<ChitietKmEntity>();
                //Tạo lisO chứa list Entity khi thực thi StroreProcedure
                var lisO = dbContext.SP_GET_ALL_CHITIETKHUYENMAI().ToList();
                //Duyệt rồi add vào lisDMSP;
                foreach (var objEntity in lisO)
                {
                    ChitietKmEntity objKM = new ChitietKmEntity
                    {
                        MALOAIKM = (int)objEntity.MALOAIKM,
                        MASP = "" + objEntity.MASP,
                        NGAYBATDAUKM = ""+objEntity.NGAYBATDAUKM,
                        NGAYKETTHUCKM = ""+objEntity.NGAYKETTHUCKM,
                        PHANTRAM = (int)objEntity.PHANTRAM,
                    };
                    lisLoaiKM.Add(objKM);
                }
            
            return lisLoaiKM;
        }


        public override ChitietKmEntity findElementById(string sValue)
        {
            throw new NotImplementedException();
        }

        public ChitietKmEntity findElementBy_MaSp_MaKm(string iTemp, string sValue)
        {
            if (dbContext == null)
                dbContext = new DB_HOABANFOOD_VER2Entities();
            var objEntity = dbContext.SP_GET_CHITIETKHUYENMAI_BY_MASP_MAKM(int.Parse(iTemp), sValue).FirstOrDefault();

            ChitietKmEntity objChitiet = new ChitietKmEntity
            {
                MALOAIKM = (int)objEntity.MALOAIKM,
                 MASP = ""+objEntity.MASP,
                 NGAYBATDAUKM = ""+objEntity.NGAYBATDAUKM,
                 NGAYKETTHUCKM = ""+objEntity.NGAYKETTHUCKM,
                 PHANTRAM = (int)objEntity.PHANTRAM,
            };
            return objChitiet;
        }
    }
}
