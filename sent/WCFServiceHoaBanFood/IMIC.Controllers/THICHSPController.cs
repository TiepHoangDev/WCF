using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models;

namespace IMIC.Controllers
{
    public class THICHSPController: BaseController<ThichSPEntity>
    {
        private ThichSPModel mThichSPModel;
        public THICHSPController()
        {
            mThichSPModel = new ThichSPModel();
        }
        public override List<ThichSPEntity> getAllElement()
        {
            return mThichSPModel.getElements();
        }
        public override ThichSPEntity getElementById(string sValue)
        {
            return mThichSPModel.findElementById(sValue);
        }
        public List<ThichSPEntity> getElementsNvThich(string sMANV)
        {
            return mThichSPModel.getElementsNvThich(sMANV);
        }
        public List<ThichSPEntity> getElementSPDuocThich(string sMASP)
        {
            return mThichSPModel.getElementSPDuocThich(sMASP);
        }
    }
}
