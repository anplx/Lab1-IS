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
    public partial class GPU : Form
    {
        StorageDevice sd;
        Model tempModel;
        FormResult FResult;
        public GPU()
        {
            InitializeComponent();
        }

        public GPU(Model model)
        {
            InitializeComponent();
            tempModel = model;
            comboBox1.Items.AddRange(tempModel.GPU());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempModel.ChangeGPU(comboBox1.Text);
            sd = new StorageDevice(tempModel);
            sd.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempModel.ChangeGPU(comboBox1.Text);
            FResult = new FormResult(tempModel);
            FResult.Show();
            this.Close();
        }
    }
}
