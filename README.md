# mididump
Dump a midi file to a human readable txt file

# Disclaimer
This "human readable" midi event format is not some kind of industry standard. It is just the '.ToString()' output of NAudio's 'NAudio.Midi.MidiEvent' objects. mididump is just an absurdly simple program that loops all midievents and outputs them to stdout, so that other programs can manipulate midi without the need to have a dependency upon NAudio

# Usage:

Put the program and the accompanying dll in your path. Then call the program passing the midi file as first argument.

Eg.:
mididump test.mid

The output will be written to the standard output. To write it to a file, use output redirection:

Eg.:
mididump test.mid > test.txt
