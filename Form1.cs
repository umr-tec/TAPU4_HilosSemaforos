using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TAPU4_MultiProceso
{
    public partial class Form1 : Form
    {
        Thread hilo;
        public Form1()
        {
            InitializeComponent();
            //Establecver valores maximos y minimos del pbCounter
            pbCounter1.Minimum = 1;
            pbCounter1.Maximum = 255;
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Hilos
            Thread hilo1 = new Thread(new ThreadStart(MostrarCajas));
            hilo1.Start();
            Thread hilo2 = new Thread(new ThreadStart(CargarProgressBar));
            hilo2.Start();

            //MostrarCajas();
        }

        //Métodos para generar acciones
        public void MostrarCajas() {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("Valor de i: {0}", i.ToString());                
            }
        }

        public void CargarProgressBar() {
            for (int i = 1; i <= 255; i++)
            {
                try
                {
                    pbCounter1.Value = i;
                    btnStart.BackColor = Color.FromArgb(i, Color.DarkBlue);
                    Thread.Sleep(200);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
                
            }
        }
      
    }
}
