using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
   public class ModeratorObserver :IObserver
    {
       public ModeratorObserver(ISubject subject) {
           this.subject = subject;
           this.subject.register(this);
       }

       
       public override void update() {
           System.Console.WriteLine("moderator: new post added");
       }
    }
}
