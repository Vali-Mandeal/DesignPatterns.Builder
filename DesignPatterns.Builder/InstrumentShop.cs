namespace DesignPatterns.Builder
{
    using StringedInstrumentBuilder;

    /// <summary>
    /// The 'Director' class
    /// </summary>
    class InstrumentShop
    {
        // You can have multiple ways of constructing different type of instruments
        // For example, this director could receive a Percussion Instrument Builder

        public void Construct(Builder builder)
        {
            builder.BuildName();
            builder.BuildStrings();
            builder.BuildScale();
            builder.BuildFrets();
            builder.BuildColor();
        }
    }
}
