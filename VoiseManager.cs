using System;
using System.Speech.Synthesis;


namespace Twister
{
    public class VoiseManager
    {
        SpeechSynthesizer _speechSynth { get; set; }
        public VoiseManager()
        {
            _speechSynth = new SpeechSynthesizer();
            _speechSynth.Volume = 100;
        }
    }
}
