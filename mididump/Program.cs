using System;
using System.Linq;
using NAudio.Midi;

namespace mididump {
    class MainClass {
        public static void Main(string[] args) {
            foreach(var e in new MidiFile(args[0]).Events.SelectMany(e => e)) {
                Console.WriteLine(e);
            }
        }
    }
}
