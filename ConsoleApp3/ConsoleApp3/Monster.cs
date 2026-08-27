namespace ConsoleApp3;

public class Monster
{
    public string Name;
    public int Hp;

    public void TakeDamage(int damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            Hp = 0;
        }
        
        Console.WriteLine(Name + " 남은 체력 " + Hp);  
    }
}