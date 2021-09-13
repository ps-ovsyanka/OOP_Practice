using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Практическая_4__массивы_
{
    class Class2
    {

        static void Main3()
        {
			int a, b;
			string s = ReadLine();
			string[] ss = s.Split(' ');
			a = Int32.Parse(ss[0]);
			b = Int32.Parse(ss[1]);


			//ничьей быть не может
			if (a == b)
			{
				 Write("No solution");
			}
			else if (Math.Abs(a - b) > 3)
			{
				Write("No solution");
			}
			else if (a > 5 || b > 5)
			{   //если больше пяти ударов, то разница должна быть меньше 1

				if (Math.Abs(a - b) > 1)
				{
					Write("No solution");
				}
				else
				{
					if (a > b)
                    {
						WriteLine("Russia");
						WriteLine(new string ('+', a));
						Write(new string('+', b));
						Write("-");
					} else
                    {
						WriteLine("France");
						
						Write(new string('+', a));
						WriteLine("-");
						WriteLine(new string('+', b));
					}
				}
			}
			else
			{ //все остальные
				switch (s) {
					case "0 1":
						WriteLine("France");
						WriteLine("-----");
						WriteLine("----+");
						break;
					case "0 2":
						WriteLine("France");
						WriteLine("----");
						WriteLine("++-");
						break;
					case "0 3":
						WriteLine("France");
						WriteLine("---");
						WriteLine("+++");
						break;
					case "1 0":
						WriteLine("Russia");
						WriteLine("----+");
						WriteLine("-----");
						break;
					case "1 2":
						WriteLine("France");
						WriteLine("---+-");
						WriteLine("---++");
						break;
					case "1 3":
						WriteLine("France");
						WriteLine("+---");
						WriteLine("+++");
						break;
					case "2 0":
						WriteLine("Russia");
						WriteLine("++--");
						WriteLine("----");
						break;
					case "2 1":
						WriteLine("Russia");
						WriteLine("++---");
						WriteLine("+----");
						break;
					case "2 3":
						WriteLine("France");
						WriteLine("++---");
						WriteLine("+++-");
						break;
					case "2 4":
						WriteLine("France");
						WriteLine("++--");
						WriteLine("++++");
						break;
					case "3 0":
						WriteLine("Russia");
						WriteLine("+++");
						WriteLine("---");
						break;
					case "3 1":
						WriteLine("Russia");
						WriteLine("+++-");
						WriteLine("+---");
						break;
					case "3 2":
						WriteLine("Russia");
						WriteLine("+++--");
						WriteLine("++---");
						break;
					case "3 4":
						WriteLine("France");
						WriteLine("+++--");
						WriteLine("++++");
						break;
					case "4 1":
						WriteLine("Russia");
						WriteLine("++++");
						WriteLine("+--");
						break;
					case "4 2":
						WriteLine("Russia");
						WriteLine("++++");
						WriteLine("++--");
						break;
					case "4 3":
						WriteLine("Russia");
						WriteLine("++++-");
						WriteLine("+++--");
						break;
					case "4 5":
						WriteLine("France");
						WriteLine("++++-");
						WriteLine("+++++");
						break;
					case "5 3":
						WriteLine("Russia");
						WriteLine("+++++");
						WriteLine("+++-");
						break;
					case "5 4":
						WriteLine("Russia");
						WriteLine("+++++");
						WriteLine("++++-");
						break;
					default:
						Write("No solution");
						break;

				}
			}
		}
    }
}
