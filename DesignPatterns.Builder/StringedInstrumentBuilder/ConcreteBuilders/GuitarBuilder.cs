using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.StringedInstrumentBuilder.ConcreteBuilders
{
    class GuitarBuilder : Builder
    {
        public GuitarBuilder()
        {
            _stringedInstrument = new StringedInstrument("Guitar");
        }
        public override void BuildName()
        {
            _stringedInstrument["name"] = "TBRM 2.7";
        }

        public override void BuildStrings()
        {
            _stringedInstrument["strings"] = "7";
        }

        public override void BuildScale()
        {
            _stringedInstrument["scale"] = "25.5";
        }

        public override void BuildFrets()
        {
            _stringedInstrument["frets"] = "24";
        }

        public override void BuildColor()
        {
            _stringedInstrument["color"] = "Red Blood Matte";
        }
    }
}
