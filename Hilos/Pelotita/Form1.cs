using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pelotita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            // Descomentar para que ande.

            // Utilizo Pelotita Sin Thread.
             //Pelotitas_sin_Thread.Pelotita pelotita = new Pelotitas_sin_Thread.Pelotita(this.pictureBox1);


            //Utilizo Pelotita Con Thread.
            // Pelotitas_con_Thread.Pelotita pelotita = new Pelotitas_con_Thread.Pelotita(this.pictureBox1);

            //Muestra el resultado en form1.
            // pelotita.DoWork();

        }
    }
}
