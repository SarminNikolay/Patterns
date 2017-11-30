using System;

namespace AbstractFactorySample {
    class Program {
        static void Main (string[] args) {
            var myWindow = new Window (new BlackPlasticWindowFactory ());
            System.Console.WriteLine ("Параметры заказа:");
            myWindow.GetMaterial ();
            myWindow.GetColor ();
        }
    }
}