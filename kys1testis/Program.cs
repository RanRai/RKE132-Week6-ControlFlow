//Programm loeb kokku, mitu 'L' tähte on antud sõnes. Programm arvestab sellega,
//et 'L' täht võib olla nii suur (upper register), kui ka väike (lower register).

string hello = "Hello, world!".Trim();//Trim oli tesits vale, mis selle asemele peab tulema?
int counter = 0;
for (int i = 0; i < hello.Length; i++)
{
    if (hello[i] == 'l')
    {
        counter++;
    }
}
Console.WriteLine($"There are {counter} l's in the stinrg \"{hello}\"");