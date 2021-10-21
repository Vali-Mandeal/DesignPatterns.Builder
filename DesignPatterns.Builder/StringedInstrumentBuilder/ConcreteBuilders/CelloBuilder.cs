using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.StringedInstrumentBuilder.ConcreteBuilders
{
    class CelloBuilder : Builder
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
            _stringedInstrument["frets"] = "fret less";
        }

        public override void BuildColor()
        {
            _stringedInstrument["color"] = "tiny wood";
        }
    }
}
