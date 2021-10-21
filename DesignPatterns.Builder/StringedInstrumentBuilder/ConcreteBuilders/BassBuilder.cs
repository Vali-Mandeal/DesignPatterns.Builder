using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.StringedInstrumentBuilder.ConcreteBuilders
{
    class BassBuilder : Builder
    {
        public BassBuilder()
        {
            _stringedInstrument = new StringedInstrument("Bass");
        }
        public override void BuildName()
        {
            _stringedInstrument["name"] = "AB";
        }

        public override void BuildStrings()
        {
            _stringedInstrument["strings"] = "5";
        }

        public override void BuildScale()
        {
            _stringedInstrument["scale"] = "35";
        }

        public override void BuildFrets()
        {
            _stringedInstrument["frets"] = "24";
        }

        public override void BuildColor()
        {
            _stringedInstrument["color"] = "Aged natural matte";
        }
    }
}
