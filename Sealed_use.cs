using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
    class X
    {
        public void Display()
        {
            Console.WriteLine("Display From X");
        }
        public virtual void Show()
        {
            Console.WriteLine("Show From X");
        }
    }
    class Y : X
    {
        public void Test()
        {
            Console.WriteLine("Test From Y");
        }
        public new void Display()
        {
            Console.WriteLine("Display From Y");
        }
        sealed public override void Show()
        {
            base.Show();
            Console.WriteLine("Show From Y");
        }
    }
    class P : Y
    {
        public override void Show()
        {
            Console.WriteLine("Show From Y");
        }
    }

    internal class Seald_use
    {
        static void Main(string[] arg)
        {
            //Declare Instances of class
            X instance_of_x = new X();
            Y instance_of_y = new Y();

            //CallingConvention method
            instance_of_x.Display();
            instance_of_y.Display();

            instance_of_x.Show();
            instance_of_y.Show();

            instance_of_y.Test();
        }
    }
}
