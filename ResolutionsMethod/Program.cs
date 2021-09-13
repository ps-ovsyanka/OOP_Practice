using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodResolution
{
	class Program
	{
		public static bool[] CreateBoolArrayTrue(int size)
		{
			bool[] mas = new bool[size];
			for (int i = 0; i < size; i++) mas[i] = true;
			return mas;
		}
		public static int FindFirstIndexTrue(bool[] mas)
		{
			for (int i = 0; i < mas.Length; i++)
			{
				if (mas[i] == true) { return i; }
			}
			return -1;
		}
		public static char OppositeCase(char c)
		{
			if (Char.IsUpper(c)) return Char.ToLower(c);
			if (Char.IsLower(c)) return Char.ToUpper(c);
			return ' ';
		}

		public static string JoinsChars(char[] mas, char separator)
		{
			string res = "";
			for (int i = 0; i < mas.Length; i++)
			{
				res += mas[i];
				if (i != mas.Length - 1) res += separator;
			}
			return res;
		}

		public static string RemoveChar(string s, char c)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == c)
				{
					s.Remove(i+1, 1);
				}
			}
			return s;
		}

		public static string ReplaceLower(string s)
        {
			string res = "";
			for(int i = 0; i < s.Length; i++)
            {
				if(Char.IsLower(s[i]) & s[i] != 'v')
                {
					char c = (char)OppositeCase(s[i]);
					res += '!' + c.ToString() ;
                }
				else
                {
					res += s[i];
                }
            }
			return res;
        }

		public static char[][] ToCharArray(Disjunct[] input)
        {
			char[][] res = new char[input.Length][];
			for(int i = 0;i< input.Length; i++) 
            {
				res[i] = new char[input[i].values.Count];
				for(int j = 0; j < res[i].Length; j++)
                {
					res[i][j] = input[i].values[j];
                }
            }
			return res;
        }


		static void Main(string[] args)
		{
			Console.WriteLine("Дизъюнкты: ");
			string dis = Console.ReadLine();
			dis = RemoveChar(dis, ' ');
			string[] formulas = dis.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			Disjunct[] input = new Disjunct[formulas.Length];
			for (int i = 0; i < input.Length; i++)
			{
				input[i] = new Disjunct(formulas[i]);
			}



			Disjunct[] res = Disjunct.ResolutionsMethod(new List<Disjunct>(input));
			for (int i = 0; i < res.Length; i++) 
			{
				Console.Write(i + ") ");
				if (res[i].Formula == "") Console.Write("[] ");
				else Console.Write(res[i].Formula + " ");

				if (res[i].a + res[i].b != 0) Console.Write(res[i].a + "-" + res[i].b);
				
				if (i + 1 == input.Length) Console.Write("\n---------------------------");
				Console.WriteLine();
			}
		}
	}
}
