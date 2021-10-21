using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.StringedInstrumentBuilder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class Builder
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
