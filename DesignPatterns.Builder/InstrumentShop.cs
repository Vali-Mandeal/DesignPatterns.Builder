namespace DesignPatterns.Builder.V1
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    class InstrumentShop
    {
        // You can have multiple ways of constructing different type of instruments
        // For example, this director could receive a Percussion Instrument AbstractBuilder

        public void Construct(StringedInstrumentBuilder.AbstractBuilder abstractBuilder)
        {
            abstractBuilder.BuildName();
            abstractBuilder.BuildStrings();
            abstractBuilder.BuildScale();
            abstractBuilder.BuildFrets();
            abstractBuilder.BuildColor();
        }
    }
}
