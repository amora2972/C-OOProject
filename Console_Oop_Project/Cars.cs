using System;
using System.Collections.Generic;

namespace Console_Oop_Project
{
    class Cars
    {
        private string carModel;
        private string carName;
        private int carYear;
        private Double pricePerYear;
        private Double pricePerMonth;
        private Double pricePerDay;

        public string CarModel
        {
            get
            {
                return this.carModel;
            }
            set
            {
                this.carModel = value;
            }
        }
        public string CarName
        {
            get
            {
                return this.carName;
            }
            set
            {
                this.carName = value;
            }
        }
        public int CarYear
        {
            get
            {
                return this.carYear;
            }
            set
            {
                this.carYear = value;
            }
        }
        public double PricePerYear
        {
            get
            {
                return this.pricePerYear;
            }
            set
            {
                this.pricePerYear = value;
            }
        }
        public double PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                this.pricePerMonth = value;
            }
        }
        public double PricePerDay
        {
            get
            {
                return this.pricePerDay;
            }
            set
            {
                this.pricePerDay = value;
            }
        }

        public List<Cars> getCars()
        {
            var cars = new List<Cars>();
            cars.Add(new Cars()
            {
                CarModel = "HA18",
                CarName = "Hyundai Accent",
                CarYear = 2018,
                PricePerDay = 15,
                PricePerMonth = 25,
                PricePerYear = 27,
            });
            cars.Add(new Cars()
            {
                CarModel = "HA17",
                CarName = "Hyundai Accent",
                CarYear = 2017,
                PricePerDay = 10,
                PricePerMonth = 12,
                PricePerYear = 23,
            });
            cars.Add(new Cars()
            {
                CarModel = "HA15",
                CarName = "Hyundai Accent",
                CarYear = 2015,
                PricePerDay = 5,
                PricePerMonth = 13,
                PricePerYear = 18,
            });
            cars.Add(new Cars()
            {
                CarModel = "FD18",
                CarName = "Fiat Doblo",
                CarYear = 2018,
                PricePerDay = 20,
                PricePerMonth = 35,
                PricePerYear = 50,
            });
            cars.Add(new Cars()
            {
                CarModel = "FD16",
                CarName = "Fiat Doblo",
                CarYear = 2016,
                PricePerDay = 15,
                PricePerMonth = 20,
                PricePerYear = 35,
            });
            return cars;
        }

        public Double getTotal(int duration, double PricePerD, double PricePerM, double PricePerY)
        {
            double total = 0;
            if (duration < 30)
            {
                total = duration * PricePerD;
            }
            else if (duration > 30 && duration < 180)
            {
                total = PricePerM * duration;
            }
            else
            {
                total = PricePerY * duration;
            }
            return total;
        }

        public void print()
        {
            Console.WriteLine(carModel + " " + carName + " " + carYear + " " + pricePerYear);
        }
    }
}
