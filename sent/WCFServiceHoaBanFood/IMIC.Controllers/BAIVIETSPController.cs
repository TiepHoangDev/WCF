using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models;

namespace IMIC.Controllers
{
    public class BAIVIETSPController : BaseController<BAIVIETSPEntity>
    {
        BAIVIETSPModel  m_Model;
        public BAIVIETSPController()
        {
            m_Model = new BAIVIETSPModel();
        }

        public override List<BAIVIETSPEntity> getAllElement()
        {
            return m_Model.getElements();

        }

        public override BAIVIETSPEntity getElementById(string sValue)
        {
            throw new NotImplementedException();
        }

        public BAIVIETSPEntity findElementByMASP(string sMASP)
        {
            return m_Model.findElementByMASP(sMASP);
        }
    }
}
