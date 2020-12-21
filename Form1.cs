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
    public partial class Form1 : Form
    {
        FormQuestionOne OneQ;
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();    
        }

        private void button1_Click(object sender, EventArgs e) //Начать
        {
            OneQ = new FormQuestionOne(model);
            OneQ.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Данная система предназначена для помощи пользователям, которые хотят подобрать нужную им конфигурацию ПК",
                "Справка",
                MessageBoxButtons.OK);
        }
    }
}
