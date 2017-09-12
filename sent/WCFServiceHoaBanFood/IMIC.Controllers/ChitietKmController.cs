using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.Models;
using IMIC.EntityObjects;

namespace IMIC.Controllers
{
    public class ChitietKmController : BaseController<ChitietKmEntity>
    {
        private ChitietKmModel mChitietKMModel;
        public ChitietKmController()
        {
            mChitietKMModel = new ChitietKmModel();
        }

        public override List<ChitietKmEntity> getAllElement()
        {
            return mChitietKMModel.getElements();
        }
        public override ChitietKmEntity getElementById(string sValue)
        {
            throw new NotImplementedException();
        }
        public ChitietKmEntity findElementBy_MaSp_MaKm(string iTemp, string sValue)
        {
            return mChitietKMModel.findElementBy_MaSp_MaKm(iTemp, sValue);
        }
    }
}
