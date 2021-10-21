using DesignPatterns.Builder.V1.Models;

namespace DesignPatterns.Builder.V1.StringedInstrumentBuilder.ConcreteBuilders
{
    public class CelloBuilder : AbstractBuilder
    {
        public CelloBuilder()
        {
            _stringedInstrument = new StringedInstrument("Guitar");
        }
        public override void BuildName()
        {
            _stringedInstrument["name"] = "The big bad cello";
        }

        public override void BuildStrings()
        {
            _stringedInstrument["strings"] = "4";
        }

        public override void BuildScale()
        {
            _stringedInstrument["scale"] = "40";
        }

        public override void BuildFrets()
        {
            _stringedInstrument["frets"] = "fretless";
        }

        public override void BuildColor()
        {
            _stringedInstrument["color"] = "Tiny Wood";
        }
    }
}
