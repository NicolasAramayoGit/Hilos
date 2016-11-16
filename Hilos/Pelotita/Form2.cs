using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // Incluimos esta librería.


namespace Pelotita
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btn_crear_Click(object sender, EventArgs e)
        {


            //Pelotitas_sin_Thread.Pelotita pelotita = new Pelotitas_sin_Thread.Pelotita(this.pictureBox1);

            Pelotitas_con_Thread.Pelotita pelotita = new Pelotitas_con_Thread.Pelotita(this.pictureBox1);
            Thread nuevoHilo = new Thread(pelotita.DoWork);

            // Para que muestre el resultado en el form2.
            //pelotita.DoWork();

            nuevoHilo.Start();
        }
    }
}
