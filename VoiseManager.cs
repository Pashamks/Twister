using System;
using System.Speech.Synthesis;


namespace Twister
{
    public class VoiseManager
    {
       public  SpeechSynthesizer SpeechSynth { get; set; }
        public VoiseManager()
        {
            SpeechSynth = new SpeechSynthesizer();
            SpeechSynth.Volume = 100;
            SpeechSynth.Rate = 0;
            SpeechSynth.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Senior);
        }
    }
}
