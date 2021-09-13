using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodResolution
{
	public class Disjunct
	{
		private String formula;
		public int a = 0;
		public int b = 0;
		public List<char> values;
		public string Formula { 
			get { 
				return formula; 
			} 
		}
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
			formula = Program.ReplaceLower(Program.JoinsChars(values.ToArray(), 'v'));
		}

		public static bool operator !=(Disjunct a, Disjunct b) { return a.Formula != b.Formula; }
		public static bool operator ==(Disjunct a, Disjunct b) { return a.Formula == b.Formula; }




		public static Disjunct[] ResolutionsMethod(List<Disjunct> input)
		{
			int ofset = 0;
			int count = 0;
			List<bool> indexes = new List<bool>(Program.CreateBoolArrayTrue(input.Count));
			List<char[]> result = new List<char[]>();
			for(int i = 0; i < input.Count; i++)
            {
				result.Add(input[i].values.ToArray());
            }
			 
			

			while (result.Last()[0] != ' ')
			{
				int index = Program.FindFirstIndexTrue(indexes.ToArray());//если еще есть дизъюнкты для сравнения

				bool flag = false;//метка совпадения


				for (int i = index; i < result.Count; i++)
				{
                    if (!indexes[i])
                    {
						i++;
						break;
                    }
					for (int j = 0; j < result[i].Length; j++)
					{
						char c = Program.OppositeCase(result[i][j]);
						for (int ii = i+1; ii < result.Count; ii++)
						{
							if (!indexes[ii])
							{
								i++;
								break;
							}
							for (int jj = j; jj < result[ii].Length; jj++)
							{
								if (result[ii][jj] == c)
								{
									List<char> a = new List<char>(result[i]);
									a.Remove(Program.OppositeCase(c));
									List<char> b = new List<char>(result[ii]);
									b.Remove(c);
									indexes[i] = false;
									indexes[ii] = false;
									string newDis = Program.JoinsChars(a.ToArray(), 'v') + 'v' + Program.JoinsChars(b.ToArray(), 'v');
									Disjunct d = new Disjunct(newDis);
									d.a = i;
									d.b = ii;
									input.Add(d);
									result.Add(d.values.ToArray());
									indexes.Add(true);
									flag = true;
								}
								if (flag) break;
							}
							if (flag) break;
						}
						if (flag) break;
					}
					if (flag) break;
				}


				/*if (count > indexes.Count)
                {
					ofset++;
					indexes = new List<bool> (Program.CreateBoolArrayTrue(input.Length));
					result = new List<Disjunct>(input);
					count = 0;
                }

				bool flag = false;//метка совпадения

				int index = Program.FindFirstIndexTrue(indexes.ToArray());//если еще есть дизъюнкты для сравнения
				if (index != -1)
				{
					int i = 0;
					int indexFind = 8;
					while (i < result[index].values.Count & !flag)//проход подизъюнктам
					{
						char c = Program.OppositeCase(result[index].values[i]);
						int j;
						if (i == 0) j = ofset; else j = 0;
						while ((j < result.Count & !flag))
						{
							indexFind = Array.IndexOf(result[j].values.ToArray(), c);
							if (j != i & indexes[j] & indexFind != -1)
							{
								List<char> a = result[index].values;
								a.Remove(Program.OppositeCase(c));
								List<char> b = result[j].values;
								b.Remove(c);
								indexes[index] = false;
								indexes[j] = false;
								string newDis = Program.JoinsChars(a.ToArray(), 'v') + 'v' + Program.JoinsChars(b.ToArray(), 'v');
								Disjunct d = new Disjunct(newDis);
								d.a = index;
								d.b = j;
								result.Add(d);
								indexes.Add(true);
								flag = true;
							}
							j++;
						}
						i++;
					} 
				}*/
			}


			return input.ToArray();
		}
	}
}
