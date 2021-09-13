using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laba_10
{
    public class Milk : Product
    {
        int fattiness;

        public Milk(): base()
        {
            fattiness = 0;
        }
        public Milk(string n, int p, int day, int month, int year, int f) : base(n, p, day, month, year)
        {
            fattiness = f ;
        }

        public void Show()
        {
            base.Show();
            Write("\nЖирность: " + fattiness + "%");
        }

        public override void ShowVirtual()
        {
            base.ShowVirtual();
            Write("\nЖирность: " + fattiness + "%");
        }

        public object Clone()
        {
            int day = Int32.Parse(ExpipationDate.Split('.')[0]);
            int month = Int32.Parse(ExpipationDate.Split('.')[1]);
            int year = Int32.Parse(ExpipationDate.Split('.')[2]);
            return new Milk(name, price, day, month, year, fattiness);
        }

        public override string ToString()
        {
            return base.ToString() + "\nЖирность: " + fattiness + "%";
        }
    }
}
