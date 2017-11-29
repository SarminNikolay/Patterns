using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    public class Circle : IFigure
    {
        private int radius;
        public Point Point { get; set; }
        
        public Circle(int radius, int x, int y)
        {
            this.radius = radius;
            Point = new Point { X = x, Y = y };
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public object DeepCopy()
        {
            object figure = null;
            using ( MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binaryFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);
                figure = binaryFormatter.Deserialize(tempStream);
            }

            return figure;
        }

        public void GetInfo()
        {
            System.Console.WriteLine($"Круг радиусом {radius} и центром в точке({Point.X}, {Point.Y})");
        }
    }
}