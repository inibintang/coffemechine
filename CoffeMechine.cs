using System;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk milk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.milk = milk;
        }

        public String makeEsspresso()
        {
            if(!this.waterGalon.isAvailable()){
                return "sorry, water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "sorry, coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "espresso is rede";
        }

        public String makeCapucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "sorry, water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "sorry, coffe is empty";
            }

            if (!this.milk.isAvailable())
            {
                return "sorry, milk is empty";
            }

            this.waterGalon.makeOneCup();
            this.milk.makeOneCup();
            this.coffePowder.makeOneCup();
            return "capucino is rede";
        }

        public String checkAvailability()
        {
            return $"the water: {this.waterGalon.getVolume()} and the coffe powder: { this.coffePowder.getNetto()} and the milk: {this.milk.getMilk()}";
        }
    }
}