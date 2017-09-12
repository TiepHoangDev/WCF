using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models;

namespace IMIC.Controllers 
{
    public class ANHSPController : BaseController<ANHSPEntity>
    {
        ANHSPModel m_Model;
        public ANHSPController()
        {
            m_Model = new ANHSPModel();
        }

        public override List<ANHSPEntity> getAllElement()
        {
            return m_Model.getElements();

        }

        public override ANHSPEntity getElementById(string sValue)
        {
            return m_Model.findElementById(sValue);
        }

        public List<ANHSPEntity> getAllAnhBySP(string MASP)
        {
            return m_Model.getAllAnhBySP(MASP);

        }
    }
}
