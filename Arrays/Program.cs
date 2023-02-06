
//string[] fruit = { "apples", "bananas", "oranges" };// AINULT sama tüüpi 

string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length; //leiab massivis sõnade/elementide arvu

Console.WriteLine($"There are {fruitArrayLength} in your array.");

for (int i = 0; i < fruitArrayLength; i++)    //sellega kuvan kogu loetelu ja arvu, saab kasutada andmebaasi korral. saan muuta SISU!
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); //muudan suureks täheks algustähe
}

foreach (string element in fruit)
{
    Console.WriteLine(element);//siia kirjutan, mida ma soovin teha (hetkel kuvab)
}
