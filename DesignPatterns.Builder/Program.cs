using DesignPatterns.Builder.V1.StringedInstrumentBuilder.ConcreteBuilders;
using DesignPatterns.Builder.V1.StringedInstrumentBuilder;
namespace DesignPatterns.Builder.V1
{
    class Program
    {
        static void Main()
        {
            InstrumentShop shop = new();

            AbstractBuilder abstractBuilder = new GuitarBuilder();
            shop.Construct(abstractBuilder);
            abstractBuilder.StringedInstrument.Show();

            abstractBuilder = new BassBuilder();
            shop.Construct(abstractBuilder);
            abstractBuilder.StringedInstrument.Show();

            abstractBuilder = new CelloBuilder();
            shop.Construct(abstractBuilder);
            abstractBuilder.StringedInstrument.Show();
        }   
    }
}
