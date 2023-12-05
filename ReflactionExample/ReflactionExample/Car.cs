using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionExample
{
    internal class Car
    {

        public string Color;
        private int _speed;
        private string vikesh; //privatr mrmber ko accses nho mol sakya
        private string ribnkesh;

        public int Speed
        {
            get { return _speed; }
        }

        public void Accelerate(int accelerateBy)
        {
            //Adjust the speed  
            _speed += accelerateBy;
        }

        public bool IsMoving()
        {
            //Is the car's speed zero?  
            if (Speed == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Car()
        {
            //Set the default values  
            Color = "White";
            _speed = 0;
        }

        public Car(string color, int speed)
        {
            Color = color;
            _speed = speed;
        }
        //methods  
        public double calculateMPG(int startMiles, int endMiles, double gallons)
        {
            return (endMiles - startMiles) / gallons;
        }

    }
}
