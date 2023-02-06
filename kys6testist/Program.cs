
string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();
string randomColor = colors[rnd.Next(0, colors.Length)];

Console.WriteLine($"You shoud wear {randomColor} today.");
