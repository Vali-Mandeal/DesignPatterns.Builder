# DesignPatterns.Builder
This is a demonstration from my DesignPattern series.

This app is building different related objects (Instruments) using Builder Pattern.

There are two versions.

V1 - Abstract Builder - It contains just one Abstract Builder /StringedInstrumentsBuilder/AbstractBuilder.cs,
but more can be added and called from within the "Director" class: "/InstrumentShop.cs".

V2 - Fluent Builder - It's a simple builder that implements a Fluent Api so the build steps can be elegantly chained in the client class.
