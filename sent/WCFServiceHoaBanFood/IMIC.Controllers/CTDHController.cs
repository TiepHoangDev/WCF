using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.Models.DataModel;
using IMIC.Models;
using IMIC.EntityObjects;

namespace IMIC.Controllers
{
    public class CTDHController : BaseController<CTDHEntity>
    {
        private CTDHModel mCTDHModel;
        public CTDHController()
        {
            mCTDHModel = new CTDHModel();
        }

        public override List<CTDHEntity> getAllElement() 
        {
            return mCTDHModel.getElements();
        }

        public override CTDHEntity getElementById(string sValue)
        {
            throw new NotImplementedException();
        }

        public List<CTDHEntity> getDataAll()
        {
            throw new NotImplementedException();
        }
    }
}
