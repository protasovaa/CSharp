using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel
{
    public class Car
    {
        private string brand;
        private int power;
        private int places;
        public Car(string name, int power, int places)
        {
            this.brand = name;
            this.power = power;
            this.places = places;
        }
        public string getName()
        {
            return brand;
        }
        public void setName(string name)
        {
            this.brand = name;
        }
        public int getPower()
        {
            return power;
        }
        public void setPower(int power)
        {
            this.power = power;
        }
        public int getPlaces()
        {
            return places;
        }
        public void setPlaces(int places)
        {
            this.places = places;
        }

        public virtual double quality()
        {
            double Q = 0.1 * Math.Round(Convert.ToDouble(getPlaces()) * Convert.ToDouble(getPower()), 2);
            return Q;
        }
        public virtual string info()
        {
            return "Название марки авто: " + getName() + Environment.NewLine + "Мощность: " + getPower() + Environment.NewLine + "Количество мест: " + getPlaces();
        }
    }
    public class CarSecondLevel: Car
    {
        private int year;
        public CarSecondLevel(string name, int power, int places,int year): base(name,power,places)
        {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public override double quality()
        {
          double Q = base.quality();
          double Qp = Q - 1.5 * (2022 - year);
          return Qp;
        }
    }
}
