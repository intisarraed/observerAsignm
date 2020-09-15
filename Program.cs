using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new ISubject();
            new ModeratorObserver(subject);
            new TrackerObserver(subject);

            System.Console.WriteLine("enter your post as following (username, title, body, postdate):");
            string post= Console.ReadLine();

            subject.setPost(post);
            Console.ReadKey();
        }
    }
}
