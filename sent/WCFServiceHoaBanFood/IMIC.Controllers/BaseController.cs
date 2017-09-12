using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.Controllers
{
    public abstract class BaseController<T>
    {
        public virtual List<T> getAllElement() { return null; }
        public abstract T getElementById(string sValue);
    }
}
