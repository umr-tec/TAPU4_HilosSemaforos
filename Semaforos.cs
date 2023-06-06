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
    public partial class Semaforos : Form
    {
        //Crear hilos
        Thread[] hilos = new Thread[3];
        ProgressBar[] progressBars = new ProgressBar[3];

        //Crear el semaforo
        Semaphore semaphore = new Semaphore(2, 2);
        public Semaforos()
        {
            InitializeComponent();
            //Asignar cada prigressBar al arreglo
            progressBars[0] = pbCounter1;
            progressBars[1] = pbCounter2;
            progressBars[2] = pbCounter3;

            for (int i = 0; i < 3; i++)
            {
                progressBars[i].Minimum = 0;
                progressBars[i].Maximum = 255;
                progressBars[i].Style = ProgressBarStyle.Blocks;
            }            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                hilos[i] = new Thread(new ParameterizedThreadStart(IncremetaHilos));
                hilos[i].IsBackground = true;
                hilos[i].Start(i);
            }
        }


        //MEtodo para incrementar los progressBar
        void IncremetaHilos(object state) {
            int numHilo = (int)state;
            int valor = 0;

            while (valor < 255 )
            {
                semaphore.WaitOne();
                for (int i = 0; i < 1000; i++)
                {
                    ++valor;
                    if (valor <= 255)
                    {
                        progressBars[numHilo].Invoke(new MethodInvoker(delegate {
                            progressBars[numHilo].Value = valor;
                        }     
                        ));
                    }
                }
                semaphore.Release();
            }
        }
    }
}
