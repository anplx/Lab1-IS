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
    public partial class FormQuestionThree : Form
    {
        Model tempModel;
        FormResult FResult;
        CPU cpu;
        public FormQuestionThree()
        {
            InitializeComponent();
        }

        public FormQuestionThree(Model model)
        {
            InitializeComponent();
            tempModel = model;
        }
        private void button2_Click(object sender, EventArgs e) // Показать результат
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show(
                    "Выберете тип ПК",
                    "Предупреждение",
                    MessageBoxButtons.OK);
            }
            else
            {
                tempModel.GetThreeQ(comboBox1.Text);
                tempModel.FixateConfiguration();
                FResult = new FormResult(tempModel);
                FResult.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) //Перейти к доп.вопросам
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show(
                    "Выберите тип ПК",
                    "Предупреждение",
                    MessageBoxButtons.OK);
            }
            else
            {
                tempModel.GetThreeQ(comboBox1.Text);
                tempModel.FixateConfiguration();
                cpu = new CPU(tempModel);
                cpu.Show();
                this.Close();
            }
        }
    }
}
