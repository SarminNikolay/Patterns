using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer desktopDeveloper = new DesktopDeveloper("DesktopDev");
            App desktopApp = desktopDeveloper.CreateApp();

            Developer webDeveloper = new WebDeveloper("WebDev");
            App webApp = webDeveloper.CreateApp();
        }
    }
}
