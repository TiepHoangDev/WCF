using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.Models;
using IMIC.EntityObjects;

namespace IMIC.Controllers
{
    public class DDHController : BaseController<DDHEntity>
    {
        private DDHModel mDDHModel;
        public DDHController()
        {
            mDDHModel = new DDHModel();
        }

        public override List<DDHEntity> getAllElement() 
        {
            return mDDHModel.getElements();
        }

        public override DDHEntity getElementById(string sValue)
        {
            throw new NotImplementedException();
        }
    }
}
