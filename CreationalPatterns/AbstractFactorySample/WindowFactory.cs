using System;

namespace AbstractFactorySample
{
        abstract class Color
        {
            public abstract void GetColor();
        }

        //Классы описания возможных цветов окна
        class White : Color
        {
            public override void GetColor()
            {
                System.Console.WriteLine("Цвет: Белый");
            }
        }

        class Black : Color
        {
            public override void GetColor()
            {
                System.Console.WriteLine("Цвет: Черный");
            }
        }

        abstract class Material
        {
            public abstract void GetMaterial();
        }

        //Классы описания возможных видов материала
        class Wood : Material
        {
            public override void GetMaterial()
            {
                System.Console.WriteLine("Материал: Дерево");
            }
        }

        class Plastic : Material
        {
            public override void GetMaterial()
            {
                System.Console.WriteLine("Материал: Пластик");
            }
        }

        abstract class WindowFactory
        {
            public abstract Material SetMaterial();
            public abstract Color SetColor();
        }

        //Классы описания фабрик объектов
        class WhiteWoodWindowFactory : WindowFactory
        {
            public override Color SetColor()
            {
                return new White();
            }

            public override Material SetMaterial()
            {
                return new Wood();
            }
        }

        class WhitePlasticWindowFactory : WindowFactory
        {
            public override Color SetColor()
            {
                return new White();
            }

            public override Material SetMaterial()
            {
                return new Plastic();
            }
        }

        class BlackPlasticWindowFactory : WindowFactory
        {
            public override Color SetColor()
            {
                return new Black();
            }

            public override Material SetMaterial()
            {
                return new Plastic();
            }
        }

        //Реализация класса продукта
        class Window
        {
            private Color Color;
            private Material Material;

            public Window(WindowFactory factory)
            {
                Color = factory.SetColor();
                Material = factory.SetMaterial();
            }

            public void GetMaterial()
            {
                Material.GetMaterial();
            }

            public void GetColor()
            {
                Color.GetColor();
            }
        }
}