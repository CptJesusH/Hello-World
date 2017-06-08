using System;
using System.Speech;
using System.Speech.Synthesis;

namespace WhatTheFuckDidYouJustSay {
    class Program {
        static void Main(string[] args) {

            SpeechSynthesizer speech = new SpeechSynthesizer();
            while (true) {
                Console.WriteLine("Tell me what to say!");
                string whatToSay = Console.ReadLine();
                speech.Speak(whatToSay);
                continue;
            }
            

        }
    }
}
