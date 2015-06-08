using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MateuszChmielowskiLab6ZadDom
{
    /// <summary>
    /// Klasa LogInForm jest oknem logowania. Jest typu sealed - nie można po niej dziedziczyć.
    /// Jest przykładem użycia wzorca singleton.
    /// </summary>
    public sealed partial class FormLogIn : Form
    {
        /// <summary>
        /// Jedyna instancja klasy, do której dostęp jest tylko z metody GetLogInForm().
        /// </summary>
        private static FormLogIn logInFormInstance;
        /// <summary>
        /// Obiekt służący do synchronizacji w wielowątkowych aplikacjach.
        /// </summary>
        private static object syncLock = new object();
        /// <summary>
        /// Zmienna pomocnicza, przechowuje stan okna.
        /// </summary>
        private static bool isHidden = true;
 
        /// <summary>
        /// Prywatny konstruktor inicjalizujący okno.
        /// </summary>
        private FormLogIn()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda, która zwraca jedyną instancję singletonu. Jeśli instancja nie została
        /// zainicjalizowana, to w tej metodzie zostanie utworzona.
        /// </summary>
        /// <returns></returns>
        public static FormLogIn GetLogInForm()
        {
            if (logInFormInstance == null)
            {
                // zabezpieczenie przed zablokowaniem przez wielowątkowe aplikacje,
                // gdy metoda jest wywoływana funkcją Invoke()
                lock (syncLock)
                {
                    logInFormInstance = new FormLogIn();
                }
 
            }
            return logInFormInstance;
        }
        /// <summary>
        /// Przeciążenie metody Show(), po to aby uaktualnić stan okna, a dopiero potem
        /// wywołać standardowy Show().
        /// </summary>
        public new void Show()
        {
            if (isHidden)
            {
                isHidden = false;
            }
            base.Show();
        }
        /// <summary>
        /// W momencie zamykania okna, standardowa akcja zostaje zatrzymana, a okno zostaje
        /// ukryte, po to aby referencja do okna nie została utracona.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            isHidden = true;
            logInFormInstance.Hide();
        }
        /// <summary>
        /// Metoda sprawdza czy pola hasło i login nie są puste, następnie czy podano prawdiłowy
        /// login i hasło. Jeśli tak, wywołuje funkcję zamykającą okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Należy wypełnić oba pola.");
            }
            if (textBoxLogin.Text == "kredek" && textBoxPassword.Text == "haslo")
            {
                MessageBox.Show("Poprawnie zalogowano, okno singleton zostanie ukryte.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.")
            }
        }
    }
}
