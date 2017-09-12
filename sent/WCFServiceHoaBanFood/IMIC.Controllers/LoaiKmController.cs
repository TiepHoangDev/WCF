using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.Models;
using IMIC.EntityObjects;

namespace IMIC.Controllers
{
    public class LoaiKmController : BaseController<LoaiKmEntity>
    {
        private LoaiKmModel mLoaiKMModel;
        public LoaiKmController()
        {
            mLoaiKMModel = new LoaiKmModel();
        }

        public override List<LoaiKmEntity> getAllElement()
        {
            return mLoaiKMModel.getElements();
        }

        public override LoaiKmEntity getElementById(string sValue)
        {
            return mLoaiKMModel.findElementById(sValue);
        }
    }
}
