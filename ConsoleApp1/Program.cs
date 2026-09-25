using System.ComponentModel.Design.Serialization;

int heroHp = 100;   
int villainHp = 100;

string heroName = "kalle";
string villainName = "olof";

while (heroHp > 0 && villainHp > 0)
{
    Console.WriteLine("----===={New round}=====-----");
    Console.WriteLine($"{heroName}:{heroHp} {villainName}: {villainHp}");

    int heroDamage = Random.Shared.Next(14, 17);
    villainHp -= heroDamage;
    villainHp = Math.Max(0, villainHp);
    Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

    int villainDamage = Random.Shared.Next(20);
    heroHp -= villainDamage;
    heroHp = Math.Max(0, heroHp);
    Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

    Console.WriteLine("Tryck på ett valfri knapp för att fortsätta");
    Console.ReadKey();
}

Console.WriteLine("-----{The Battle is now done}-----");

if (heroHp == 0 && villainHp == 0)

{
  Console.WriteLine("It was a tie and we got not winner!");
}
else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} vann!");
}
else
{
  Console.WriteLine($"{heroName} vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();