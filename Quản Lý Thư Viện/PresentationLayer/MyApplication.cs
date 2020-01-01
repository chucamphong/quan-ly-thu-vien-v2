using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer.Forms;

namespace PresentationLayer
{
    internal class MyApplication : WindowsFormsApplicationBase
    {
        protected override void OnCreateMainForm()
        {
            this.MainForm = new LoginForm();
        }

        protected override void OnCreateSplashScreen()
        {
            this.SplashScreen = new SplashForm();
        }
    }
}