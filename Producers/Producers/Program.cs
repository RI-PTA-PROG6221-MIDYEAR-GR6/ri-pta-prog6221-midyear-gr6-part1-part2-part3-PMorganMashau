using System;
using System.Media;

SoundPlayer sound = new SoundPlayer("sound.wav");
sound.Play();

Console.WriteLine("Plaay sound?(Y/N)");
string ans = Console.ReadLine();

if (ans.ToUpper() == "Y")
{
    Console.WriteLine("Playing sound...");
    sound.Play();
}
else
{
    Console.WriteLine("Sound not played.");
}