﻿//Programm loeb tühikuid antud lauses ja kuvab lauses olevate sõnade arvu konsoolis.
string hello = "Hello, world!".Trim();
int spaceCounter = 0;
for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        spaceCounter++;
    }
}
Console.WriteLine(spaceCounter + 1);
