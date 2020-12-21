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
    public partial class StorageDevice : Form
    {
        RAM ram;
        Model tempModel;
        FormResult FResult;
        public StorageDevice()
        {
            InitializeComponent();
        }

        public StorageDevice(Model model)
        {
            InitializeComponent();
            tempModel = model;
            comboBox2.Items.AddRange(tempModel.StorageDevice());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempModel.ChangeSD(comboBox1.Text, comboBox2.Text);
            ram = new RAM(tempModel);
            ram.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempModel.ChangeSD(comboBox1.Text, comboBox2.Text);
            FResult = new FormResult(tempModel);
            FResult.Show();
            this.Close();
        }
    }
}
