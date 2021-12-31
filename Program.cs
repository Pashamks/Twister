using System;
using System.Speech.Synthesis;

namespace Twister
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speechSynth = new SpeechSynthesizer(); // создаём объект

            speechSynth.Volume = 100; // устанавливаем уровень звука
            speechSynth.Speak("Right foot on green"); // озвучиваем переданный текст

          
        }
    }
}
