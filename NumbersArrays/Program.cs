
int[] numbers = new int[10];//massiivi tüüp ja suurus
Random rnd= new Random();//genereerib suvalised numbrid. (rnd on ümber nimetatud random)

int sum = 0;

//populating the array (massiivi täitmine)
for (int i = 0;i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, numbers.Length +1);
    sum = sum + numbers[i];
}

foreach(int number in numbers)
{
    Console.WriteLine(number);//kuvab genereeritud numbrid
}
Console.WriteLine($"Total: {sum}");//liidab numbrid ja kuvab summa