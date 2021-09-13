using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба__7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void onClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)  {
                case ("btn_one_array"):
                    FormOneArray formOneArray = new FormOneArray(this);
                    formOneArray.Show();
                    break;
                case ("btn_two_array"):
                    FormTwoArray formTwoArray = new FormTwoArray(this);
                    formTwoArray.Show();
                    break;
                case ("btn_ragged_array"):
                    FormRaggedArray formRaggedArray = new FormRaggedArray(this);
                    formRaggedArray.Show();
                    break;

            }
            this.Enabled = false;
            
        }
    }
}
