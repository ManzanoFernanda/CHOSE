using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace CHOSE
{
    public partial class INICIO:Form
    {
        public INICIO()
        {
            InitializeComponent();

        }
            private void CircularButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(CHOSE.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();
            

            Form formulario = new PUNTOS();
            formulario.Show();
            this.Hide();



        }
      

        private void CircularButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    
        public void Espera()
        {
            Thread.Sleep(1500);
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void circularButton2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(CHOSE.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();


            Form formulario = new NOMBRE();
            formulario.Show();
            this.Hide();

        }
    }
}


