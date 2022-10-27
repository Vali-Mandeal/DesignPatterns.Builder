using DesignPatterns.Builder.V2.FluentBuilder;
using DesignPatterns.Builder.V2.Models;

namespace DesignPatterns.Builder.V2
{
    class Program
    {
        private static IStringedInstrumentsBuilder _builder = new StringedInstrumentsBuilder();

        static void Main()
        {
            Show(BuildOneEspArrowGuitar());
            Show(BuildOneSolarBassGuitar());
            Show(BuildOneBigBadCello());
        }

        private static StringedInstrument BuildOneEspArrowGuitar()
        {
            return _builder
                .WithType("Guitar")
                .WithName("ESP Arrow")
                .WithStrings(6)
                .WithScale(25.5)
                .WithFrets("24")
                .WithColor("Black")
                .Build();
        }

        private static StringedInstrument BuildOneSolarBassGuitar()
        {
            return _builder
                .WithType("Bass Guitar")
                .WithName("AB")
                .WithStrings(5)
                .WithScale(35)
                .WithFrets("24")
                .WithColor("Aged Natural Matte")
                .Build();
        }

        private static StringedInstrument BuildOneBigBadCello()
        {
            return _builder
                .WithType("Cello")
                .WithName("The Big Bad Cello")
                .WithStrings(4)
                .WithScale(40)
                .WithFrets("Fretless")
                .WithColor("Tiny Wood")
                .Build();
        }

        private static void Show(StringedInstrument instrument)
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Instrument Type: {instrument.Type}");
            Console.WriteLine($" Name : {instrument.Name}");
            Console.WriteLine($" Strings : {instrument.Strings}");
            Console.WriteLine($" Scale : {instrument.Scale}");
            Console.WriteLine($" Frets : {instrument.Frets}");
            Console.WriteLine($" Color: {instrument.Color}");
        }
    }
}