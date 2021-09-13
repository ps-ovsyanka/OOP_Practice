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

    public partial class Form1 : Form
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

        TextBox mainScreen;
        public Button btnResult;
        public Button btnA;
        public Button btnB;
        public Button btnDel;
        public Button btnClear;
        public Button btnBktOpen;
        public Button btnBktClose;
        public Button btnAnd;
        public Button btnOr;
        public Button btnNot;
        public Button btnImplicat;
        public Button btnEqual;

        public Label msg;

        public Form1()
        {
            InitializeComponent();

            mainScreen = this.main_screen;
            msg = this.label_msg;

            btnResult = this.btn_res;
            btnA = this.btn_A;
            btnB = this.btn_B;
            btnDel = this.btn_delete;
            btnClear = this.btn_clear;
            btnBktOpen = this.btn_bracket_open;
            btnBktClose = this.btn_bracket_close;
            btnAnd = this.btn_and;
            btnOr = this.btn_or;
            btnNot = this.btn_not;
            btnImplicat = this.btn_implicat;
            btnEqual = this.btn_equal;
            
        }


        public void onClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String mainTxt = mainScreen.Text;
            
            switch (btn.Name)
            {
                case ("btn_delete"):
                    if (mainTxt != "") mainScreen.Text = mainTxt.Substring(0, mainTxt.Length - 1);
                    msg.Text = "";
                    break;
                case ("btn_clear"):
                    mainScreen.Text = "";
                    msg.Text = "";
                    break;
                case ("btn_not"):
                case ("btn_A"):
                case ("btn_B"):
                    if (mainTxt == "" || mainTxt.Last() != 'A' & mainTxt.Last() != 'B' & mainTxt.Last() != ')')
                    {
                        mainScreen.Text += btn.Text;
                        msg.Text = "";
                    }
                    else
                    {
                        msg.Text = "Ошибка синтаксиса";
                    }
                    break;
                case ("btn_bracket_open"):
                    if (mainTxt == "" || mainTxt.Last() != 'A' & mainTxt.Last() != 'B')
                    {
                        mainScreen.Text += btn.Text;
                        msg.Text = "";
                    }
                    else
                    {
                        msg.Text = "Ошибка синтаксиса";
                    }
                    break;
                case ("btn_bracket_close"): 
                    if (mainTxt.Contains("(") && (mainTxt == "" || mainTxt.Last() == 'A' | mainTxt.Last() == 'B'))
                    {
                        mainScreen.Text += btn.Text;
                        msg.Text = "";
                    }
                    else
                    {
                        msg.Text = "Ошибка синтаксиса";
                    }
                    break;
                case ("btn_and"):
                case ("btn_or"):
                case ("btn_implicat"):
                case ("btn_equal"):
                case ("btn_xor"):
                case ("btn_shtrih"):
                case ("btn_pirs"):
                    if (mainTxt != "" && (mainTxt.Last() == 'A' | mainTxt.Last() == 'B' | mainTxt.Last() == ')'))
                    {
                        mainScreen.Text += btn.Text;
                        msg.Text = "";
                    }
                    else
                    {
                        msg.Text = "Ошибка синтаксиса";
                    }
                    break;
                case ("btn_res"):
                    if (mainTxt == "")
                    {
                        msg.Text = "Ошибка. Пустая строка";
                    }
                    else if (operations.Contains(mainTxt[mainTxt.Length - 1]))
                    {
                        msg.Text = "Ошибка синтаксиса";
                    }
                    else 
                    {
                        FormResult formResult = new FormResult(mainScreen.Text);
                        formResult.Show();
                    }
                    
                    break;
            };
        }
    }


}
