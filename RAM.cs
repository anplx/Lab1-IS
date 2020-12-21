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
    public partial class RAM : Form
    {
        Model tempModel;
        FormResult FResult;
        public RAM()
        {
            InitializeComponent();
        }

        public RAM(Model model)
        {
            InitializeComponent();
            tempModel = model;
            comboBox1.Items.AddRange(tempModel.RAM());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempModel.ChangeRAM(comboBox1.Text);
            FResult = new FormResult(tempModel);
            FResult.Show();
            this.Close();
        }
    }
}
