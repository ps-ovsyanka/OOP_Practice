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
    public partial class FormRaggedArray : Form
    {
        Form1 mainForm;
        public FormRaggedArray(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public void onClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
