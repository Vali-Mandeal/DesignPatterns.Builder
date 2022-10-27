using DesignPatterns.Builder.V2.Models;

namespace DesignPatterns.Builder.V2.FluentBuilder
{
    public interface IStringedInstrumentsBuilder
    {
        IStringedInstrumentsBuilder WithType(string type);
        IStringedInstrumentsBuilder WithName(string name);
        IStringedInstrumentsBuilder WithStrings(int strings);
        IStringedInstrumentsBuilder WithScale(double scale);
        IStringedInstrumentsBuilder WithFrets(string frets);
        IStringedInstrumentsBuilder WithColor(string color);

        StringedInstrument Build();
    }   
}