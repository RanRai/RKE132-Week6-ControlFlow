string hello = " we are the champions?"; //string hello loeb sisuks võrdusmärgi järgse teksti

int stringLength = hello.Length;

//string trimmedString = hello.Trim();//lõikab tühiku ära " "des oleva lause või üksiku sõna eest ja tagant

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');
//asendan väikse h suure Hga. Nüüd asendab sõltumata sõnast esime väiketähe suurega. Asendan ? märgi ! märgiga.

firstLetter= hello[0]; //salvestan firstLetter väärtuse ümber
Console.WriteLine(firstLetter);//kuvan uuesti suurt tähte

Console.WriteLine(hello);//kuvab muudetud tervikteksti

//int wordCounter = 1;
//for(int i = 0; i <hello.Length ; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }//Console.WriteLine($"{i} symbol in string: {hello[i]}"); kuvab tähe kohanumbri lauses
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");