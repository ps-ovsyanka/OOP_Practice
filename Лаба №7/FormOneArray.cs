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
    public partial class FormOneArray : Form
    {

        Form1 mainForm;
        TextBox textBoxArray;
        public FormOneArray(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
            textBoxArray = this.text_array;
        }



        private void FormOneArray_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            String txtArray = textBoxArray.Text.ToString();
            String[] arr = txtArray.Split(',');
            DeleteEvenIndex(ref arr);
            textBoxArray.Text = String.Join(",", arr);
        }

        private void DeleteEvenIndex(ref String[] array)
        {
            String[] temp;
            if (array.Length % 2 == 0) temp = new String[array.Length / 2];
            else temp = new String[(array.Length + 1) / 2];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = array[i * 2];
            }
            array = temp;
        }
    }
}
