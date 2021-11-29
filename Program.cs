using System;

namespace pokemon
{
    enum Energy
    {
        Grass,
        Fire,
    }

    class Card
    {
        public string Name;
        public bool Summoned;
        public bool Tapped;
        public bool Discarded;
        public Energy EnergyType;

        /// <summary>
        /// sets default values Summoned & Activated to false
        /// </summary>
        public void Init()
        {
            this.Summoned = false;
            this.Tapped = false;
            this.Discarded = false;
        }

        public bool _summon()
        {
            if (this.Discarded)
            {
                Console.WriteLine("Cannot summon a discarded card: " + this.ToString());
                return false;
            }
            else if (this.Summoned == true)
            {
                Console.WriteLine("Cannot summon an already summoned card: " + this.ToString());
                return false;
            }
            else
            {
                this.Summoned = true;
                return true;
            }
        }

        public bool _tap()
        {
            if (this.Discarded)
            {
                Console.WriteLine("Cannot tap a discarded card: " + this.ToString());
                return false;
            }
            else if (!this.Summoned)
            {
                Console.WriteLine("Cannot tap a not summoned card: " + this.ToString());
                return false;
            }
            else if (this.Tapped)
            {
                Console.WriteLine("Cannot tap an already tapped card: " + this.ToString());
                return false;
            }
            else
            {
                this.Tapped = true;
                return true;
            }
        }

        public bool _discard()
        {
            if (this.Discarded == true)
            {
                Console.WriteLine("Cannot discard an already discarded card: " + this.ToString());
                return false;
            }
            else if (this.Summoned == true)
            {
                Console.WriteLine("Cannot discard a summoned card: " + this.ToString());
                return false;
            }
            else
            {
                this.Discarded = true;
                return true;
            }
        }

        public override string ToString()
        {
            return this.Name + ", energy: " + this.EnergyType.ToString() + ", summoned: " + this.Summoned.ToString()
                + ", tapped: " + this.Tapped.ToString() + ", discarded: " + this.Discarded.ToString();
        }
    }

    class Grass : Card
    {
        public Grass(string name)
        {
            this.Init();
            this.Name = name;
            this.EnergyType = Energy.Grass;
            Console.WriteLine("A grass pokémon with name " + name + " created.");
        }

        public void summon()
        {
            if (this._summon())
                Console.WriteLine("You summoned a grass card: " + this.Name);
            else
                Console.WriteLine("Unabled to summon grass card: " + this.Name);
        }

        public void tap()
        {
            if (this._tap())
                Console.WriteLine("You activated a grass card: " + this.Name);
            else
                Console.WriteLine("Unabled to activate grass card: " + this.Name);

        }

        public void discard()
        {
            if (this._discard())
                Console.WriteLine("You discarded a grass card: " + this.Name);
            else
                Console.WriteLine("Unabled to discard grass card: " + this.Name);

        }
    }

    class Fire : Card
    {
        public Fire(string name)
        {
            this.Init();
            this.Name = name;
            this.EnergyType = Energy.Fire;
            Console.WriteLine("A fire pokémon with name " + name + " created.");
        }

        public void summon()
        {
            if (this._summon())
                Console.WriteLine("You summoned a fire card: " + this.Name);
            else
                Console.WriteLine("Unabled to summon fire card: " + this.Name);
        }

        public void tap()
        {
            if (this._tap())
                Console.WriteLine("You activated a fire card: " + this.Name);
            else
                Console.WriteLine("Unabled to activate fire card: " + this.Name);

        }

        public void discard()
        {
            if (this._discard())
                Console.WriteLine("You discarded a fire card: " + this.Name);
            else
                Console.WriteLine("Unabled to discard fire card: " + this.Name);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Grass travnicek = new Grass("trávníček");
            Fire ohnicek = new Fire("ohníček");

            travnicek.tap();
            travnicek.summon();
            travnicek.summon();
            travnicek.discard();
            travnicek.tap();

            ohnicek.summon();
            ohnicek.tap();
            ohnicek.tap();
            ohnicek.discard();
            ohnicek.discard();
            ohnicek.summon();

            Console.ReadLine();
        }
    }
}
