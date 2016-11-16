using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace iUN_UWP10_UNAL
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            this.InitializeComponent();
        }

        private void WebViewNavigate(string URI)
        {
            Frame.Navigate(typeof(WebViewPage), URI);
        }

        private void OnButtonMainPageClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("unal.edu.co");
        }

        private void OnButtonLDGClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("divulgacion.unal.edu.co");//FIXME
        }

        private void OnButtonLibreriaClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("uneditorial.com");
        }

        private void OnButtonRadioClick(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void OnButtonPeriodicoClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("unperiodico.unal.edu.co");
        }

        private void OnButtonPrismaClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("untelevision.unal.edu.co");//FIXED
        }

        private void OnButtonMuseosClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.unal.edu.co/contenido/patrimonio_historico.html");
        }

        private void OnButtonAdmisionesClick(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void OnButtonLaboratoriosClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("laboratorios.unal.edu.co");
        }

        private void OnButtonCorreoClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("login.unal.edu.co/cloudkey/a/unal.edu.co/user/login?namespace=unal.edu.co");
        }

        private void OnButtonComedoresClick(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void OnButtonMedicoClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.bienestarbogota.unal.edu.co/salud.php");
        }

        private void OnButtonUnisaludClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("unisalud.unal.edu.co");
        }

        private void OnButtonComitePrevencionClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.bienestar.unal.edu.co");//FIXME
        }

        private void OnButtonIPARMClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.unal.edu.co/iparm");
        }

        private void OnButtonFodunClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.fodun.com.co");
        }

        private void OnButtonCooperativaClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("cooprofesoresun.coop");
        }

        private void OnButtonSIAClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("sia.unal.edu.co");
        }

        private void OnButtonSinabClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("sinab.unal.edu.co");
        }

        private void OnButtonHERMESClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.hermes.unal.edu.co");
        }

        private void OnButtonDREClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.ori.unal.edu.co");
        }

        private void OnButtonTalentoHumanoClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.sara.unal.edu.co");
        }

        private void OnButtonWebDocenteClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("www.docentes.unal.edu.co");
        }
    }
}