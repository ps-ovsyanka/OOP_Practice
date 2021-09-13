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
    public partial class FormTwoArray : Form
    {

        Form1 mainForm;
        RichTextBox textBoxArray;
        RichTextBox textBoxAddedArray;
        public FormTwoArray(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            textBoxArray = this.txt_array;
            textBoxAddedArray = this.txt_added_array;

        }

        public void onClosed (object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string[] stringLines = new string[textBoxAddedArray.Lines.Length];
            for (int i = 0; i < textBoxAddedArray.Lines.Length; i++)
                if (textBoxAddedArray.Lines[i] != "") 
                    stringLines[i] = textBoxAddedArray.Lines[i];
                else 
                    Array.Resize(ref stringLines, stringLines.Length - 1);

            int col = stringLines.Length;
            int row = stringLines[0].Split(',').Length;
            string[,] addedArr = new string[row, col];
            for (int j = 0; j < col; j++)//заполнение массива столбцов
            {
                string[] line = stringLines[j].Split(',');
                for (int i = 0; i < row; i++)
                {
                    addedArr[i, j] = line[i];
                }
            }


            stringLines = new string[textBoxArray.Lines.Length];
            for (int i = 0; i < textBoxArray.Lines.Length; i++)
                if (textBoxArray.Lines[i] != "")
                    stringLines[i] = textBoxArray.Lines[i];
                else
                    Array.Resize(ref stringLines, stringLines.Length - 1);
            row = stringLines.Length;
            col = (stringLines[0].Split(',')).Length;
            string[,] arr = new string[row, col];
            for (int i = 0; i < row; i++)//заполнение двумерно массива
            {
                String[] line = stringLines[i].Split(',');
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = line[j];
                }
            }

            int index = int.Parse(this.index.Text);

            AddColumns(ref arr, index, addedArr);

            txt_array.Text = "";
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    txt_array.Text += arr[i, j] + ',';
                }
                txt_array.Text = txt_array.Text.Remove(txt_array.Text.Length - 1, 1);
                txt_array.Text += "\n";
            }
            txt_array.Text = txt_array.Text.Remove(txt_array.Text.Length - 1, 1);

        }

        /// <summary>
        /// Добавить К столбцов, начиная со столбца с номером N
        /// </summary>
        /// <param name="array"></param>
        /// <param name="k"></param>
        /// <param name="n"></param>
        private void AddColumns(ref string[,] arr, int index, string[,] values)
        {
            int row = values.GetLength(0);
            int col = arr.GetLength(1) + values.GetLength(1);
            int n = values.GetLength(1);
            string[,] temp = new string[row, col];

            for (int j = 0; j < index - 1; j++)
            {
                for (int i = 0; i < row; i++) temp[i, j] = arr[i, j];
            }
            for (int j = index - 1; j < index + n - 1; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    temp[i, j] = values[i,j - index + 1];
                }
            }
            for (int j = index + n - 1; j < col; j++)
            {
                for (int i = 0; i < row; i++) temp[i, j] = arr[i, j - n];
            }

            arr = temp;
        }
    }
}
