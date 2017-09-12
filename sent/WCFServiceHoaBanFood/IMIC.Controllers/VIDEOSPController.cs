using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models;

namespace IMIC.Controllers
{
    public class VIDEOSPController : BaseController<VIDEOSPEntity>
    {
        VIDEOSPModel m_Model;

        public VIDEOSPController()
        {
            m_Model = new VIDEOSPModel();
        }
        public override List<VIDEOSPEntity> getAllElement()
        {
            return m_Model.getElements();
        }
        public override VIDEOSPEntity getElementById(string sValue)
        {
            throw new NotImplementedException();
        }

        public VIDEOSPEntity findElementByMaSP(string sMASP)
        {
            return m_Model.findElementByMaSP(sMASP);
        }
    }
}
