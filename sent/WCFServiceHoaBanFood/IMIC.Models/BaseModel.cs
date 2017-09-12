using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.Models
{
    public abstract class BaseModel<T>
    {
        public virtual List<T> getElements() { return null; }
        public abstract T findElementById(string sValue);

    }
}
