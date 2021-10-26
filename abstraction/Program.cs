using System;

namespace abstraction
{
    public abstract class car
    {
        //abstrct mathod without any body
        public abstract void carColor();
        //regular method
        public void name()
        {
            Console.WriteLine("jupiter");
        }
    }
    //derived class(inherit from animal)
    class swift : car
    {
        public override void carColor()
        {
            //the body of the car color() is provide here
            Console.WriteLine("merron");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            swift s = new swift();
            s.carColor();
            s.name();
            
        }
    }
}
