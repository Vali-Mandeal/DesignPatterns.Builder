using DesignPatterns.Builder.V1.Models;

namespace DesignPatterns.Builder.V1.StringedInstrumentBuilder
{
    /// <summary>
    /// The 'AbstractBuilder' abstract class
    /// </summary>
    public abstract class AbstractBuilder
    {
        protected StringedInstrument _stringedInstrument;
            
        // Gets Instrument instance
        public StringedInstrument StringedInstrument => _stringedInstrument;

        // Abstract build methods   
        public abstract void BuildName();
        public abstract void BuildStrings();
        public abstract void BuildScale();
        public abstract void BuildFrets();
        public abstract void BuildColor();
    }   
}
