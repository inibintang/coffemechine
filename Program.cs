using System;

namespace TheCoffeMechine

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello kopi");

            Milk milk = new Milk(1000);
            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe, water, milk);


            //1 espresso
            Console.WriteLine("check " +yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " +result);
            //2
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
             result = yummyCoffe.makeCapucino();
            Console.WriteLine("result " + result);
            //3
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);
            //4
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);
            //5
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());

        }
    }
}
