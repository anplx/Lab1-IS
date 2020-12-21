using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class CPU : Form
    {
        Model tempModel;
        GPU gpu;
        FormResult FResult;
        public CPU()
        {
            InitializeComponent();
        }

        public CPU(Model model)
        {
            InitializeComponent();
            tempModel = model;
            comboBox1.Items.AddRange(tempModel.CPU());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempModel.ChangeCPU(comboBox1.Text);
            gpu = new GPU(tempModel);
            gpu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempModel.ChangeCPU(comboBox1.Text);
            FResult = new FormResult(tempModel);
            FResult.Show();
            this.Close();
        }
    }
}
