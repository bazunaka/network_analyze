using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation_of_the_shortest_network
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Введите размерность массива:";
            this.button1.Text = "ОК!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.BackColor = Color.Red;
        }
    }

    class Edge
    {
        public int v1, v2, weight;

        public Edge(int v1, int v2, int weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }
    }
}
