using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
   public class TrackerObserver :IObserver
    {
       public TrackerObserver(ISubject subject) {
           this.subject = subject;
           this.subject.register(this);
       }

       public override void update() {
          System.Console.WriteLine("tracker: there are new post");
       }
    }
}
