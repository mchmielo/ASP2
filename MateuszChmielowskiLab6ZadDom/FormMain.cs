using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszChmielowskiLab6ZadDom
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Po wciśnięciu przycisku ButtonLogin zostaje pobrana referencja do singletonu
        /// okna FormLogIn po czym okno zostaje załadowane. Jako, że jest to singleton,
        /// nie ma możliwości załadować więcej niż jedną instancję okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            FormLogIn logInForm = FormLogIn.GetLogInForm();
            logInForm.Show();
        }
        /// <summary>
        /// Metoda tworzy drugi wątek, który próbuje załadować okno logowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogInInvoke_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(SecondThread.OpenFormLogIn);
            newThread.Start();
            Thread.Sleep(1);
            newThread.Abort();
        }
    }
}
