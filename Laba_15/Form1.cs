using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_15
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random();
        private List<int> mas_one;
        private List<int> mas_two;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            
            mas_one = new List<int>(10);
            mas_two = new List<int>(10);

            for (int i = 0; i < 10; i++)
            {
                mas_one.Add(rand.Next(100));
                mas_two.Add(rand.Next(50)*2);
            }

            PrintOne(-1, -1);
            PrintTwo(-1, -1);
        }

        
        private void PrintOne(int a, int b)
        {
            listView1.Clear();

            for (int i = 0; i < 10; i++)
            {
                listView1.Items.Add(mas_one[i].ToString());
                if (i ==a | i == b)
                {                    
                    listView1.Items[i].ForeColor = Color.Red;
                }
            }
        }


        private void PrintTwo(int a, int b)
        {
            listView2.Clear();

            for (int i = 0; i < 10; i++)
            {
                listView2.Items.Add(mas_two[i].ToString());
                if (i == a | i == b)
                {
                    listView2.Items[i].ForeColor = Color.Red;
                }
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(SortOne))
            {
                Name = "thread1"
            };
            Thread t2 = new Thread(new ThreadStart(SortTwo))
            {
                Name = "thread2"
            };

            t1.Start();
            t2.Start();
        }


        private void SortOne()
        {
            int temp;
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    PrintOne(i, j);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    if (mas_one[i] > mas_one[j])
                    {
                        temp = mas_one[i];
                        mas_one[i] = mas_one[j];
                        mas_one[j] = temp;                        
                    }
                    PrintOne(i, j);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
        }
        
        private void SortTwo()
        {
            int temp;
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    PrintTwo(i, j);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    if (mas_two[i] < mas_two[j])
                    {
                        temp = mas_two[i];
                        mas_two[i] = mas_two[j];
                        mas_two[j] = temp;                        
                    }
                    PrintTwo(i, j);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
