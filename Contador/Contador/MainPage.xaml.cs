using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contador
{
    public partial class MainPage : ContentPage
    {
        int count;
        String mensaje;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            count = 0;
        }
        

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(button1 == null)
            {
                button1 = ((Button)sender);
            }
            count++;
            mensaje = "veces clikeado: {0}";
            button1.Text = string.Format(mensaje,count);
            
        }

        void Reset_Clicked(object sender, System.EventArgs e)
        {
            mensaje = " Haz Click";
            count = 0;
            if (button1 != null)
            {
                button1.Text = mensaje;
            }
        }
    }
}
