using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranZadTwoIA;

namespace TranZadIA
{
    public partial class FormSelection : Form
    {
        public FormSelection()
        {
            InitializeComponent();
        }

        private void Open_tranZad_Click(object sender, EventArgs e)
        {
            Form tranzad = new TranZad();
            tranzad.ShowDialog();
        }

        private void open_training_Click(object sender, EventArgs e)
        {
            Form training = new TrainingForm();
            training.ShowDialog();
        }

        private void open_tranZadTwo_Click(object sender, EventArgs e)
        {
            Form tranzadTwo = new TranZadTwo();
            tranzadTwo.ShowDialog();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
