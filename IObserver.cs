using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public abstract class IObserver
    {
        public abstract void update();
        protected ISubject subject; 
    }
}
