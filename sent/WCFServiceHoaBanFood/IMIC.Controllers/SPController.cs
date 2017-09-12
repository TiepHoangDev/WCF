using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.EntityObjects;
using IMIC.Models;

namespace IMIC.Controllers
{
    public class SPController : BaseController<SPEntity>
    {
         SPModel m_Model ;

        public SPController()
        {
            m_Model = new SPModel();
        }
        public override List<SPEntity> getAllElement()
        {
            return m_Model.getElements();
        }
        public override SPEntity getElementById(string sValue)
        {
            return m_Model.findElementById(sValue);
        }
        public List<SPEntity> findAllElementByMADMSP(string sMADMSP)
        {
            return m_Model.findAllElementByMADMSP(sMADMSP);
        }
    }
}
