string[] colors = { "red", "green", "blue", "pink", "yellow" };
for (int i =colors.Length - 1;i >= 0; i--)//colors.Length - 1 annab tagurpidi lugemise algpunkti; i>=0 annab lõpppunkti massiel; i-- on samm
{
    Console.WriteLine($"{colors.Length - i}. {colors[i]}");
}//{colors.Length - i} annab järjekorra numbri ja .on punkt selle järel