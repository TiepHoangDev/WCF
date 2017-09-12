using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models;
namespace IMIC.Controllers
{
    public class DMSPsController : BaseController<DMSPEntity>
    {
        private DMSPModel mDMSPModel;
        public DMSPsController()
        {
            mDMSPModel = new DMSPModel();
        }
        public override List<DMSPEntity> getAllElement()
        {
            return mDMSPModel.getElements();
        }
        public override DMSPEntity getElementById(string sValue)
        {
            return mDMSPModel.findElementById(sValue);
        }
    }
}
