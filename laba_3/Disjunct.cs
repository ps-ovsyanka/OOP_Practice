using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
	public class Disjunct
	{
		private String formula;
		List<char> values;
		public int a = 0, b = 0;
		public string Formula { get { return formula; } }
		public Disjunct(String s)
		{
			s = Program.RemoveChar(s, ' ');
			s = Program.ReplaceLower(s);
			formula = s;
			
			string[] temp = s.Split(new char[] { 'v' }, StringSplitOptions.RemoveEmptyEntries);
			values = new List<char>();
			for (int i = 0; i < temp.Length; i++)
			{
				char c = temp[i][0];
				if (Char.IsLetter(c))
				{
					values.Add(c);
				}
				else if (c == '!')
				{
					
					values.Add(Char.ToLower(temp[i][1]));
				}
			}
			if (values.Count == 0) values.Add('0');
			if (this.IsIdenticallyTrue()) { formula = "1"; }
			DeleteEqualValues();
		}

		public Disjunct(Disjunct d)
        {
			formula = d.formula;
			a = d.a;
			b = d.b;
			char[] temp = new char[d.values.Count];
			d.values.CopyTo(temp);
			values = new List<char>(temp);
        }


		bool IsIdenticallyTrue()
		{
			for (int i = 0; i < this.values.Count; i++)
			{
				if (Array.IndexOf(values.ToArray(), Program.OppositeCase(values[i])) != -1) return true;
			}

			return false;
		}
		void DeleteEqualValues()
		{
			for (int i = 0; i < this.values.Count; i++)
			{
				int index = Array.IndexOf(values.ToArray(), values[i], i + 1);
				if (index != -1)
				{
					values.RemoveAt(index);
					i--;
				}

			}
			if (values.Count == 0) formula = "1";
			formula = Program.JoinsChars(values.ToArray(), 'v');
			formula = Program.ReplaceLower(formula);
		}

		public static bool operator !=(Disjunct a, Disjunct b) { return a.Formula != b.Formula; }
		public static bool operator ==(Disjunct a, Disjunct b) { return a.Formula == b.Formula; }

		public static Disjunct[] ResolutionsMethod(Disjunct[] input)
		{
			List<List<Disjunct>> RES = new List<List<Disjunct>>();
			

			for(int f = 0; f < input.Length; f++)
            {
				input = Program.Swap(input, 0, f);
				List<bool> indexes = new List<bool>(Program.CreateBoolArrayTrue(input.Length));
				List<Disjunct> result = new List<Disjunct>((Disjunct[])input.Clone());
				int count = 0;
				while (result.Last().Formula != "0" & count < result.Count)
				{
					bool flag = false;
					//int index = Program.FindFirstIndexTrue(indexes.ToArray());
					if (count != -1)
					{
						int i = 0;
						int indexFind = 8;
						do
						{
							char c = Program.OppositeCase(result[count].values[i]);
							int j = count;
							do
							{
								indexFind = Array.IndexOf(result[j].values.ToArray(), c);
								if (j != i & indexes[j] & indexFind != -1)
								{
									char[] temp = new char[result[count].values.Count];
									result[count].values.CopyTo(temp);
									List<char> a = new List<char>(temp);
									a.Remove(Program.OppositeCase(c));

									temp = new char[result[j].values.Count];
									result[j].values.CopyTo(temp);
									List<char> b = new List<char>(temp);
									b.Remove(c);

									indexes[count] = false;
									indexes[j] = false;
									string newDis = Program.JoinsChars(a.ToArray(), 'v') + 'v' + Program.JoinsChars(b.ToArray(), 'v');
									Disjunct d = new Disjunct(newDis);
									d.a = count;
									d.b = j;
									result.Add(d);
									indexes.Add(true);
									flag = true;
								}
								j++;
							} while ((j < result.Count & !flag));
							i++;
						} while (i < result[count].values.Count & !flag);
					}
					count++;
				}
				RES.Add(result);
			}
			


			foreach(List<Disjunct> i in RES)
            {
				if (i.Last().Formula == "0") return i.ToArray();
            }
			return RES.Last().ToArray();
		}
	}
}
//!AvB,!Cv!B,C,!D,AvD