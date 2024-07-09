namespace Case8;

//refactor this game, the warrior should receive any weapon, attack another warrior and reduce the Energy points.

#region Warriors
public class Aztec
{
    public int Energy { get; set; }

    public void Attack()
    {
        //receive the enemy and reduce his energy
    }
}

public class Persian
{
    public int Energy { get; set; }

    public void Attack(){}
}

public class Samurai
{
    public int Energy { get; set; }

    public void Attack() { }
}

public class Mongolian
{
    public int Energy { get; set; }

    public void Attack() { }
}
#endregion

#region Weapons
public class Sword
{
    public int Damage => -5;
}

public class Axe
{
    public int Damage => -15;
}

public class Ballista
{
    public int Damage => -25;
}

public class Musket
{
    public int Damage => -2;
}


/// <summary>
/// You can create Alliance between warriors to increase the attack damage
/// </summary>
public class Alliance
{
    public void SimultaneousAttack()// select the enemy to attack
    {
    }
}

#endregion
class Program
{
    static void Main()
    {
        Console.WriteLine("Start the game..");
    }
}