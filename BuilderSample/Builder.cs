using System;

namespace BuilderSample
{
    abstract class ChairBuilder
    {
        public Chair Chair { get; private set; }

        public void BuildChair()
        {
            Chair = new Chair();
        }

        public abstract void SetSeat();
        public abstract void SetBack();
        public abstract void SetLegs();
    }
    
    //Сборщик стульев
    class Collector
    {
        public Chair Collect(ChairBuilder builder)
        {
            builder.BuildChair();
            builder.SetSeat();
            builder.SetBack();
            builder.SetLegs();

            return builder.Chair;
        }
    }

    class StandartChairBuilder : ChairBuilder
    {
        public override void SetBack() => this.Chair.Back = new Back() { Material = "Кожа" };

        public override void SetLegs() => this.Chair.Legs = new Legs() { Count = 4 };

        public override void SetSeat() => this.Chair.Seat = new Seat() { Material = "Кожа" };
    }

}