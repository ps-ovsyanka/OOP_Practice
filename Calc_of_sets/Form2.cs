using System;
using System.Collections.Generic;
using System.Collections;

using System.Windows.Forms;
using static System.String;

namespace Calc_of_sets
{
    public partial class Form1 : Form
    {

        char[] set_operations = {'*', 'u', '\\', '+' };
        char[] mn = { 'A', 'B' };
        public Form1()
        {
            InitializeComponent();    
        }
        /// <summary>
        /// Исключение повторов
        /// </summary>
        private string[] Distinct (string[] s)
        {
            List<string> res = new List<string>();
            string temp = Join("", s);
            for (int i = 0; i < s.Length; i++)
            {
                if (temp.IndexOf(s[i], i+1) == -1)
                {
                    res.Add(s[i]);
                }
            }
            return res.ToArray();
        }
        /// <summary>
        /// Отрицание
        /// </summary>
        /// <param name="a"></param>
        /// <param name="u">Универсальное множество</param>
        /// <returns></returns>
        private string[] Complement(string[] a, string[] u)
        {
            List<string> res = new List<string>();
            string temp = Join(",", a);
            for (int i = 0; i < u.Length; i++)
            {
                if (!temp.Contains(u[i]))//если нет в А
                {
                    res.Add(u[i]);
                }
            }
            return Distinct(res.ToArray());
        }
        /// <summary>
        /// Пересечение
        /// </summary>
        private string[] Union(string[] a, string[] b)
        {
            List<string> res = new List<string>();
            string temp = Join(",", b);
            for(int i = 0; i < a.Length; i++)
            {
                if (temp.Contains(a[i]))
                {
                    res.Add(a[i]);
                }
            }
            return Distinct(res.ToArray());
        }
        /// <summary>
        /// Объединение
        /// </summary>
        private string[] Intersect(string[] a, string[] b)
        {
            List<string> res;
            res = new List<string>(Join(",", Join(",", a), Join(",", b)).Split(','));
            
            return Distinct(res.ToArray());
        }
        /// <summary>
        /// Симметрическая разность
        /// </summary>
        private string[] SymmetricDifference(string[] a, string[] b)
        {
            List<string> res = new List<string>();
            string[] intersect = Intersect(a,b);
            string union = Join(",", Union(a, b));
            for (int i = 0; i < intersect.Length; i++)
            {
                if (!union.Contains(intersect[i]))
                {
                    res.Add(intersect[i]);
                }
            }
            return Distinct(res.ToArray());
        }


        private void btn_res_Click(object sender, EventArgs e)
        {
            try
            {
                text_error.Text = "";

                string[] set_u = text_u.Text.Split(',');//инициализация множеств
                string[] set_a = text_a.Text.Split(',');
                string[] set_b = text_b.Text.Split(',');

                set_u = Intersect(set_u, Intersect(set_b, set_a));//создание универсального множества
                text_u.Text = Join(",", set_u).ToString();

                string[] set_unit = text_expression.Text.Split(set_operations); //инициализация букв
                List<string[]> set_operands = new List<string[]>();//массив множеств
                ///замена букв множествами
                for (int i = 0; i < set_unit.Length; i++)
                {
                    switch (set_unit[i])
                    {
                        case "A":
                            set_operands.Add(set_a);
                            break;
                        case "~A":
                            set_operands.Add(Complement(set_a, set_u));
                            break;
                        case "B":
                            set_operands.Add(set_b);
                            break;
                        case "~B":
                            set_operands.Add(Complement(set_b, set_u));
                            break;
                        case "U":
                            set_operands.Add(set_u);
                            break;
                    }
                }
                text_expression.Text = Concat(text_expression.Text.Split(' '));

                string oper = Join("", (Concat(text_expression.Text.Split('~'))).Split(mn));//инициализация операций

                while (oper.Length > 0)//пока есть операции
                {
                    while (oper.IndexOf('*') != -1)//пока есть пересечения
                    {
                        int index = oper.IndexOf('*');
                        string[] temp = Union(set_operands[index], set_operands[index + 1]);//множество после операции пересечения
                        set_operands[index] = temp;
                        set_operands.RemoveAt(index + 1);
                        oper = oper.Remove(index, 1);
                    }

                    while (oper.IndexOf('\\') != -1)//пока есть разность
                    {
                        int index = oper.IndexOf('\\');
                        string[] temp = Union(set_operands[index], Complement(set_operands[index + 1], set_u));//множество после операции
                        set_operands[index] = temp;
                        set_operands.RemoveAt(index + 1);
                        oper = oper.Remove(index, 1);
                    }

                    while (oper.IndexOf('u') != -1)//пока есть объединения
                    {
                        int index = oper.IndexOf('u');
                        string[] temp = Intersect(set_operands[index], set_operands[index + 1]);//множество после операции объединения
                        set_operands[index] = temp;
                        set_operands.RemoveAt(index + 1);
                        oper = oper.Remove(index, 1);
                    }
                    while (oper.IndexOf('+') != -1)//пока есть симметричекая разность
                    {
                         int index = oper.IndexOf('+');
                         string[] temp = SymmetricDifference(set_operands[index], set_operands[index + 1]);//множество после операции
                         set_operands[index] = temp;
                         set_operands.RemoveAt(index + 1);
                         oper = oper.Remove(index, 1);
                     }


                }
                text_res.Text = Join(",", set_operands[0]).ToString();
            } 
            catch {
                text_error.Text = "Ошибка. Требуется задать все множества. Возможные операции: * ; u ; \\ ; +";
            }
        }
    }
}
