string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rnd= new Random();

int randomIndex = rnd.Next(0, snacks.Length);//genereerib 0-massiivi pikkuseni(=snacks.Length)

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");//valib hulgast - snacks ja valiku teeb genereeritud numbri järgi - randomIndex
