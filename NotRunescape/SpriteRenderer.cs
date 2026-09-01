using System.Text;

namespace NotRunescape;

public class SpriteRenderer
{
    public void DrawDamageHitspat(int damage, bool isPlayer, bool pushFront,  string? enemyName)
    {
        if( pushFront )
            Console.WriteLine();
        if (isPlayer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (enemyName != null)
            {
                Console.WriteLine($"You hit {enemyName} for {damage}!");
            }
            else
            {
                Console.WriteLine($"You hit enemy for {damage}!");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (enemyName != null)
            {
                Console.WriteLine($"{enemyName} hit you for {damage}!");
            }
            else
            {
                Console.WriteLine($"enemy hit you for {damage}!");
            }
        }
        Console.ResetColor();
    }

    public void DrawGold(int amount)
    {
        char money = '$';
        StringBuilder moneyText = new StringBuilder("[");
        for (int i = 0; i < amount; i+=50)
        {
            moneyText.Append(money);
        }
        moneyText.Append("]");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{moneyText} gold amount : {amount}");
        Console.ResetColor();
    }
}