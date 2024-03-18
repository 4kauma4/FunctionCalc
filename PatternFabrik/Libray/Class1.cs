using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carss
{
    public class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Distance { get; set; }
        public int CurrentSpeed { get; set; }

        public Car(string name, int maxSpeed, int distance)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Distance = distance;
            CurrentSpeed = 0;
        }
        
        public class CarRed : Car
        {
            public CarRed(string name, int maxSpeed, int distance) : base(name, maxSpeed, distance)
            {
                
            }
        }

    
        public class CarBlue : Car
        {
            public CarBlue(string name, int maxSpeed, int distance) : base(name, maxSpeed, distance)
            {
                
            }
        }

        
        public class CarGreen : Car
        {
            public CarGreen(string name, int maxSpeed, int distance) : base(name, maxSpeed, distance)
            {
                
            }
        }

      
        public abstract class Factory
        {
            public abstract Car CreateCar(string name, int maxSpeed, int distance);
        }

      
        public class SedanFactory : Factory
        {
            public override Car CreateCar(string name, int maxSpeed, int distance)
            {
                return new CarRed(name, maxSpeed, distance);
            }
        }

      
        public class TruckFactory : Factory
        {
            public override Car CreateCar(string name, int maxSpeed, int distance)
            {
                return new CarBlue(name, maxSpeed, distance);
            }
        }


        public class MotorcycleFactory : Factory
        {
            public override Car CreateCar(string name, int maxSpeed, int distance)
            {
                return new CarGreen(name, maxSpeed, distance);
            }
        }

            public void Accelerate()
        {
            if (CurrentSpeed < MaxSpeed)
            {
                CurrentSpeed += 10;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = MaxSpeed;
                }
            }
        }

        public void Decelerate()
        {
            if (CurrentSpeed > 0)
            {
                CurrentSpeed -= 5;
                if (CurrentSpeed < 0)
                {
                    CurrentSpeed = 0;
                }
            }
        }

        public void Move()
        {
            Accelerate();
            Distance += CurrentSpeed;
        }
    }
}