using System;
using NAudio.Wave;

class Program
{
    static void Main()
    {
        using (var audioFile = new AudioFileReader("AQUELAS COISAS - João Gomes e Tarcísio do Acordeon.mp3"))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();

            Console.WriteLine("Tocando música...");
            Console.ReadKey(); // Pausa até você apertar uma tecla
        }
    }
}
