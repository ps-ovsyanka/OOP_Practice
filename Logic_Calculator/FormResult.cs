using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Calculator
{
    public partial class FormResult : Form
    {

        const char NOT = '¬';
        const char AND = '∧';
        const char OR = '∨';
        const char IMPLICATION = '⇒';
        const char EQUAL = '⇔';
        const char XOR = '+';
        const char SHTRIH = '|';
        const char PIRS = '↓';

        const char BKT_OPEN = '(';
        const char BKT_CLOSE = ')';

        public char[] operations = { AND, OR, IMPLICATION, EQUAL, XOR, SHTRIH, PIRS };
        public char[] bkts = { '(', ')' };

        string formula;
        string result;

        RichTextBox screenRes;

        public FormResult(string s)
        {
            InitializeComponent();
            formula = s;

            screenRes = this.screen_result;

            Run(formula);

        }
        public void Run(String formula)
        {
            try
            {
                bool res;
                result = "";
                String temp = formula;
                screenRes.Text = "A  B   " + formula + "  " + "F" + "\n";
                //для А=0  В=0
                temp = temp.Replace('A', '0');
                temp = temp.Replace('B', '0');
                string details = "";
                res = Parse(temp, ref details);
                screenRes.Text += "0  0   " + details + "   " + (res ? 1 : 0) + "\n";

                temp = formula;
                temp = temp.Replace('A', '0');
                temp = temp.Replace('B', '1');
                details = "";
                res = Parse(temp, ref details);
                screenRes.Text += "0  1   " + details + "   " + (res ? 1 : 0) + "\n";

                temp = formula;
                temp = temp.Replace('A', '1');
                temp = temp.Replace('B', '0');
                details = "";
                res = Parse(temp, ref details);
                screenRes.Text += "1  0   " + details + "   " + (res ? 1 : 0) + "\n";

                temp = formula;
                temp = temp.Replace('A', '1');
                temp = temp.Replace('B', '1');
                details = "";
                res = Parse(temp, ref details);
                screenRes.Text += "1  1   " + details + "   " + (res ? 1 : 0) + "\n";

            }
            catch (Exception e)
            {
                screenRes.Text = "ERROR " + e;
            }
            
        }

        public bool Parse(String s, ref string details)
        {
            Result result = All(s, ref details);
            return result.completed;
        }

        private Result Value(String s, ref string details)
        {
            bool value;

            if (s[0] == '1' | s[0] == '0')
            {
                value = ((s[0] == '1') ? true : false);
                String restPart = s.Substring(1);
                return new Result(value, restPart);
            }
            else
            {
                return defBracket(s.Substring(0), ref details);
            }
           
        }

        private Result defNot(String s, ref string details)
        {
            Result current = new Result(false, "");
            if ( s[0] == NOT)
            {
                current = defBracket(s.Substring(1), ref details);
                current.completed = !current.completed;
                details = (current.completed ? 1 : 0) + details;
            } 
            else 
            {
                current = Value(s, ref details);
            }
            return current;
        }

        private Result defAnd(String s, ref string details)
        {

            Result current = defNot(s, ref details);
            bool completed = current.completed;
            while (current.remainder.Length > 0 && current.remainder[0] == AND)
            {
                String next = current.remainder.Substring(1);

                completed = current.completed;
                string nextDetails = "";

                if (current.remainder[0] == BKT_OPEN) current = defBracket(next, ref nextDetails);
                else current = defNot(next, ref nextDetails);

                current.completed = completed && current.completed;
                details += " " + (current.completed ? 1 : 0) + nextDetails;
            }            
            return current;
        }

        private Result defOr(String s, ref string details)
        {
            Result current = defAnd(s, ref details);
            bool completed = current.completed;

            while (current.remainder.Length > 0 && current.remainder[0] == OR)
            {

                char sign = current.remainder[0];
                String next = current.remainder.Substring(1);

                completed = current.completed;
                string nextDetails = "";

                if (current.remainder[0] == BKT_OPEN) current = defBracket(next, ref nextDetails);
                else current = defAnd(next, ref nextDetails);

                completed |= current.completed;
                current.completed = completed;
                details += " " + (current.completed ? 1 : 0) + nextDetails;
            }
            return new Result(current.completed, current.remainder);
        }

        private Result defImplication(String s, ref string details)
        {
            Result current = defOr(s, ref details);
            bool completed = current.completed;

            while (current.remainder.Length > 0 && current.remainder[0] == IMPLICATION)
            {

                char sign = current.remainder[0];
                String next = current.remainder.Substring(1);

                completed = current.completed;
                string nextDetails = "";

                if (current.remainder[0] == BKT_OPEN) current = defBracket(next, ref nextDetails);
                else current = defOr(next, ref nextDetails);

                completed = !completed | current.completed;
                current.completed = completed;
                details += "  " + (current.completed ? 1 : 0) + nextDetails;
            }
            return new Result(current.completed, current.remainder);
        }

        private Result defEqual(String s, ref string details)
        {
            Result current = defImplication(s, ref details);
            bool completed = current.completed;

            while (current.remainder.Length > 0 && current.remainder[0] == EQUAL)
            {

                char sign = current.remainder[0];
                String next = current.remainder.Substring(1);

                completed = current.completed;
                string nextDetails = "";

                if (current.remainder[0] == BKT_OPEN) current = defBracket(next, ref nextDetails);
                else current = defImplication(next, ref nextDetails);

                completed = (completed & current.completed) | (!completed & !current.completed);
                current.completed = completed;
                details += "  " + (current.completed ? 1 : 0) + nextDetails;
            }
            return new Result(current.completed, current.remainder);
        }

        private Result All(String s, ref string details)
        {
            Result current = defEqual(s, ref details);
            bool completed = current.completed;

            while (current.remainder.Length > 0 && (current.remainder[0] == XOR | current.remainder[0] == SHTRIH | current.remainder[0] == PIRS))
            {

                char sign = current.remainder[0];
                String next = current.remainder.Substring(1);

                completed = current.completed;
                string nextDetails = "";

                if (current.remainder[0] == BKT_OPEN) current = defBracket(next, ref nextDetails);
                else current = defEqual(next, ref nextDetails);

                if (sign == XOR)
                {
                    completed = (!completed & current.completed) | (completed & !current.completed);
                }
                else if (sign == SHTRIH)
                {
                    completed = !(completed & current.completed);
                }
                else if (sign == PIRS)
                {
                    completed = !(completed | current.completed);
                }

                
                current.completed = completed;
                details += " " + (current.completed ? 1 : 0) + nextDetails;
            }
            return new Result(current.completed, current.remainder);
        }



        private Result defBracket(String s, ref string details)
        {
            char zeroChar = s[0];
            if (zeroChar == BKT_OPEN)
            {
                details += " ";
                Result r = All(s.Substring(1), ref details);
                if (!(r.remainder.Length == 0) && r.remainder[0] == BKT_CLOSE)
                {
                    details += " ";
                    r.remainder = r.remainder.Substring(1);
                }
                return r;
                //details += " " + (current.completed ? 1 : 0) + nextDetails;
            }
            return All(s, ref details);
        }

    }


    class Result
    {
        public bool completed;
        public String remainder;

        public Result(bool v, String r)
        {
            this.completed = v;
            this.remainder = r;
        }
    }
}
