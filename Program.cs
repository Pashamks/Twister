using System;
using System.Speech.Synthesis;
using System.Threading;

namespace Twister
{
    class Program
    {
        static VoiseManager voiseManager;
        static Twister twister;
        static void Main(string[] args)
        {
            voiseManager = new VoiseManager();
            twister = new Twister();
            Play();
        }
        static void Play()
        {
            Console.WriteLine("Welcome to Twister!");
            voiseManager.SpeechSynth.Speak("Welcome to Twister!");
            int amount = 0;
            Console.WriteLine("Enter amount of players: ");
            voiseManager.SpeechSynth.Speak("Enter amount of players: ");
            amount = Convert.ToInt32(Console.ReadLine());
            int round = 1;
            while (true)
            {
                voiseManager.SpeechSynth.Speak("Now we start round " + round.ToString());
                Thread.Sleep(1000);
                for (int i = 1; i <= amount; i++)
                {
                    voiseManager.SpeechSynth.Speak("The turn of player " + i.ToString());
                    Thread.Sleep(1000);
                    voiseManager.SpeechSynth.Speak(twister.GetMove());

                }
                round++;
                Thread.Sleep(1000);
            }
        }
    }
}
