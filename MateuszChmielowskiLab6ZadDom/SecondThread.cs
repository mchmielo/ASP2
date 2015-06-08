using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab6ZadDom
{
    /// <summary>
    /// Klasa służy do załadowania okna FormLogIn z drugiego wątka.
    /// </summary>
    class SecondThread
    {
        /// <summary>
        /// Metoda pobiera instancję formy FormLogIn i wywołując Invoke()
        /// ładuje okno FormLogIn.
        /// </summary>
        public static void OpenFormLogIn()
        {
            FormLogIn loginForm = FormLogIn.GetLogInForm();
            loginForm.Invoke(new Action(()=>loginForm.Show()));
        }
    }
}
