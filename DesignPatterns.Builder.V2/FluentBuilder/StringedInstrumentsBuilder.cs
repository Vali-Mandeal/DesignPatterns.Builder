using DesignPatterns.Builder.V2.Models;

namespace DesignPatterns.Builder.V2.FluentBuilder
{
    public class StringedInstrumentsBuilder : IStringedInstrumentsBuilder
    {
        private readonly StringedInstrument _stringedInstrument = new();

        public IStringedInstrumentsBuilder WithColor(string color)
        {
            _stringedInstrument.Color = color;

            return this;
        }

        public IStringedInstrumentsBuilder WithFrets(string frets)
        {
            _stringedInstrument.Frets = frets;

            return this;
        }

        public IStringedInstrumentsBuilder WithName(string name)
        {
            _stringedInstrument.Name = name;

            return this;
        }

        public IStringedInstrumentsBuilder WithScale(double scale)
        {
            _stringedInstrument.Scale = scale;

            return this;
        }

        public IStringedInstrumentsBuilder WithStrings(int strings)
        {
            _stringedInstrument.Strings = strings;

            return this;
        }

        public IStringedInstrumentsBuilder WithType(string type)
        {
            _stringedInstrument.Type = type;

            return this;
        }

        public StringedInstrument Build()
            => _stringedInstrument;
    }
}
