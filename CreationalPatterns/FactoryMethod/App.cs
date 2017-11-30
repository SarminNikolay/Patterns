using System;

namespace FactoryMethod {
    abstract class App
    {

    }

    class DesktopApp : App
    {
        public DesktopApp() => System.Console.WriteLine("Создание приложения для рабочего стола");
    }

    class WebApp : App
    {
        public WebApp() => System.Console.WriteLine("Создание веб приложения");
    }
}