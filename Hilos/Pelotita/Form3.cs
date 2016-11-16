using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Pelotita
{
    public partial class Form3 : Form
    {
        Thread Hilo;
        int contador;
        public Form3()
        {
            InitializeComponent();
            
            // Pausa Pelotita.
            this.btn_pausar.Click += new EventHandler(PausarPelotita);

            // Reanuda Pelotita.
            this.btn_reanuda.Click += new EventHandler(ReanudarPelotita);

            // Destruye Pelotita.
            this.btn_destruir.Click += new EventHandler(DestruirPelotita);

            this.contador = 0;
        }


        private void PausarPelotita(object sender, EventArgs e)
        {
            this.Hilo.Suspend();
        }

        private void ReanudarPelotita(object sender, EventArgs e)
        {
            this.Hilo.Resume();
        }

        private void DestruirPelotita(object sender, EventArgs e)
        {
            this.Hilo.Abort();
        }


        private void btn_Crear_Click(object sender, EventArgs e)
        {
            //Pelotitas_sin_Thread.Pelotita pelotita = new Pelotitas_sin_Thread.Pelotita(this.pictureBox1);

            Pelotitas_con_Thread.Pelotita pelotita = new Pelotitas_con_Thread.Pelotita(this.pictureBox1);

            // Cambio esto...
            // Thread nuevoHilo = new Thread(pelotita.DoWork);

            // Por esto: 
            this.Hilo = new Thread(pelotita.DoWork);

            // Y cambio esto.
            // nuevoHilo.Start();

            // Por esto:
            this.Hilo.Start();

            // Cuenta la cantidad de pelotitas que hay.
            this.contador++;

            // Resultado por pantalla solo muestra una pelotita, no deja crear mas.
            this.btn_Crear.Click -= new System.EventHandler(this.btn_Crear_Click);


        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {

        }

        private void btn_reanuda_Click(object sender, EventArgs e)
        {

        }
    }
}
