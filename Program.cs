using System;
using System.Speech.Synthesis;
using System.Threading;

namespace Twister
{
    class Program
    {
        static VoiseManager voiseManager;
        static Twister twister;
        static string _currentMove;
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
                Console.Clear();
                Console.WriteLine("Now we start round " + round.ToString());
                voiseManager.SpeechSynth.Speak("Now we start round " + round.ToString());
                Thread.Sleep(1000);
                for (int i = 1; i <= amount; i++)
                {
                    Console.WriteLine("The turn of player " + i.ToString());
                    voiseManager.SpeechSynth.Speak("The turn of player " + i.ToString());
                    Thread.Sleep(1000);
                    _currentMove = twister.GetMove();
                    Console.WriteLine(_currentMove);
                    voiseManager.SpeechSynth.Speak(_currentMove);
                    Thread.Sleep(1000);
                    voiseManager.SpeechSynth.Speak("I repeat. The turn of player" + i.ToString() + ". Your move is : ");
                    voiseManager.SpeechSynth.Speak(_currentMove);
                    Thread.Sleep(1000);
                    voiseManager.SpeechSynth.Speak("You have 30 seconds!");
                    Thread.Sleep(30000);
                    Console.Clear();
                }
                round++;
                Thread.Sleep(1000);
            }
        }
        
    }
}
