using System;

namespace FactoryMethod
{
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer (string name)
        {
            Name = name;
        }

        abstract public App CreateApp ();
    }

    class DesktopDeveloper : Developer
    {
        public DesktopDeveloper (string name) : base (name) { }

        public override App CreateApp() => new DesktopApp();
    }

    class WebDeveloper : Developer 
    {
        public WebDeveloper (string name) : base (name) { }

        public override App CreateApp() => new WebApp();
    }
}