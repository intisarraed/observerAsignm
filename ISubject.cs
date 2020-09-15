using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace observer
{
    public class ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        private string post; 

        public void register(IObserver observer)
        {
            observers.Add(observer); 
        }

        public void unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

         public void notifyObservers(){
            foreach(IObserver observer in observers) {
            observer.update();
         } 
       }
       public void setPost(string post)
        {
             this.post = post;
             notifyObservers();
         }
   }
}
