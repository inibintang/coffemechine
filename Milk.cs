using System;

namespace TheCoffeMechine
{
    class Milk
    {
        private int milk = 0; //ml
        private int milkOneCup = 100;

        public Milk(int milk)
        {
            this.milk = milk;
        }

        public Boolean isAvailable()
        {
            return milk >= milkOneCup;
        }

        public void addMilk(int milk)
        {
            this.milk += milk;
        }

        public int makeOneCup()
        {
            this.milk= this.milk- this.milkOneCup;
            return milkOneCup;
        }

        public int getMilk()
        {
            return this.milk;
        }
    }
}
