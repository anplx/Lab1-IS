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
    public partial class FormResult : Form
    {
        Model tempModel;
        Configuration Config;
        FormQuestionOne OneQ;
        public FormResult()
        {
            InitializeComponent();
        }

        public FormResult(Model model)
        {
            InitializeComponent();
            tempModel = model;
            Config = tempModel.PickUpConfiguration();
            textBox1.Text = Config.CPU;
            textBox2.Text = Config.GPU;
            textBox3.Text = Config.RAM;
            textBox4.Text = Config.MotherBoard;
            textBox5.Text = Config.StorageDevice;
            textBox6.Text = Config.PowerSupply;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempModel.Sum = 0;
            OneQ = new FormQuestionOne(tempModel);
            OneQ.Show();
            this.Close();
        }
    }
}
