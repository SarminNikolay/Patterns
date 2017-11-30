using System;
using System.Text;

namespace BuilderSample
{
    class Chair
    {
        public Seat Seat { get; set; }
        public Back Back { get; set; }
        public Legs Legs { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Seat != null)
                sb.Append($"Материал сиденья: {Seat.Material}\n");
            if (Back != null)
                sb.Append($"Материал спинки стула: {Back.Material}\n");
            if (Legs != null)
                sb.Append($"Количество ножек: {Legs.Count.ToString()}\n");
            
            return sb.ToString();
        }
    }

    class Legs
    {
        public int Count { get; set; }
    }

    class Seat
    {
        public string Material { get; set; }
    }

    class Back
    {
        public string Material { get; set; }
    }
}