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
using CHOSE;

namespace CHOSE
{
    public partial class PERSONAJE : Form
    {
        public PERSONAJE()
        {
            InitializeComponent();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(CHOSE.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();


            Form formulario = new POLAR();
            formulario.Show();
            this.Hide();

        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(CHOSE.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();


            Form formulario = new PANDA();
            formulario.Show();
            this.Hide();

        }
        public void Espera()
        {
            Thread.Sleep(1500);
        }
    }
}
