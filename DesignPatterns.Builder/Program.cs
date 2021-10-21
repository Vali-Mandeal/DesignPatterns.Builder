using DesignPatterns;
using DesignPatterns.Builder.StringedInstrumentBuilder;
using DesignPatterns.Builder.StringedInstrumentBuilder.ConcreteBuilders;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main()
        {
            InstrumentShop shop = new();

            StringedInstrumentBuilder.Builder builder = new GuitarBuilder();
            shop.Construct(builder);
            builder.StringedInstrument.Show();

            builder = new BassBuilder();
            shop.Construct(builder);
            builder.StringedInstrument.Show();

            builder = new CelloBuilder();
            shop.Construct(builder);
            builder.StringedInstrument.Show();
        }   
    }
}
