using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder.Models
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class StringedInstrument
    {
        private readonly string _instrumentType;
        private readonly Dictionary<string, string> _assets = new();

        public StringedInstrument(string instrumentType)
        {
            _instrumentType = instrumentType;
        }

        // Indexer
        public string this[string key]
        {
            get => _assets[key];
            set => _assets[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Instrument Type: {0}", _instrumentType);
            Console.WriteLine(" Name : {0}", _assets["name"]);
            Console.WriteLine(" Strings : {0}", _assets["strings"]);
            Console.WriteLine(" Scale : {0}", _assets["scale"]);
            Console.WriteLine(" Frets : {0}", _assets["frets"]);
            Console.WriteLine(" Color: {0}", _assets["color"]);
        }
    }
}
        