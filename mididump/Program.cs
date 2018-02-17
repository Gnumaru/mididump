using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NAudio.Midi;

namespace mididump {
    class MainClass {
        public static void Main(string[] args) {
            MidiFile mf = null;

            if(args.Length > 0) mf = new MidiFile(args[0]);
            else {
                Stream stdin = Console.OpenStandardInput();
                byte[] buffer = new byte[10 * 1024];
                List<byte> bytes = new List<byte>(0);
                int count = 0;
                while((count = stdin.Read(buffer, 0, buffer.Length)) > 0) {
                    bytes.AddRange(buffer.Take(count));
                }
                mf = new MidiFile(new MemoryStream(bytes.ToArray()), true);
            }

            foreach(var e in mf.Events.SelectMany(e => e).OrderBy(e => e.AbsoluteTime)) Console.WriteLine(e);
        }
    }
}
