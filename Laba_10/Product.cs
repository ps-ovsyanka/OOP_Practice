using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laba_10
{
    public class Product : Goods
    {
        protected DateTime expirationDate;

        public string ExpipationDate {
            get
            {
                return expirationDate.ToString("dd/MM/yyyy");
            }
        }
        public void setExpipationDate(int day, int month, int year)
        {
            expirationDate = new DateTime(year, month, day);
        }

        public Product() : base() { }
        public Product(string n, int p, int day, int month, int year) : base(n, p)
        {
            setExpipationDate(day, month, year);
        }

        public void Show()
        {
            base.Show();
            Write("\nСрок годноcти: " + ExpipationDate);
        }
        public override void ShowVirtual()
        {
            base.ShowVirtual();
            Write("\nСрок годности: " + ExpipationDate);
        }

        public object Clone()
        {
            int day = Int32.Parse(ExpipationDate.Split('.')[0]);
            int month = Int32.Parse(ExpipationDate.Split('.')[1]);
            int year = Int32.Parse(ExpipationDate.Split('.')[2]);
            return new Product(name, price, day, month, year);
        }

        public override string ToString()
        {
            return base.ToString() + "\nСрок годности: " + ExpipationDate;
        }
    }
}
