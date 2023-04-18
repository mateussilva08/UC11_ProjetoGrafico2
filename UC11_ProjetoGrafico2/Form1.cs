using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_ProjetoGrafico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSolteiro_CheckedChanged(object sender, EventArgs e)
        {
            
            
                checkBoxCASADO.Enabled = false;
                checkBoxViuvo.Enabled = false;
            
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(comboBoxESTADO.Text);
            if (radioButtonMasculino.Checked)
            {
                MessageBox.Show("Gênero: Masculino");
            }
            if (radioButtonFeminino.Checked)
            {
                MessageBox.Show("Gênero: Feminino");
            }


        }

        private void checkBoxCASADO_CheckedChanged(object sender, EventArgs e)
        {
            
            
                checkBoxSolteiro.Enabled = false;
                checkBoxViuvo.Enabled = false;
                    
            
        }

        private void checkBoxViuvo_CheckedChanged(object sender, EventArgs e)
        {
            
            
                checkBoxSolteiro.Enabled = false;
                checkBoxCASADO.Enabled = false;
            
        }
    }
}
