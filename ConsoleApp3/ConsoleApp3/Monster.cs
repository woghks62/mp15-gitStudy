namespace ConsoleApp3;

public class Monster
{
    public string Name;
    public int HP { get; set; }

    public void TakeDamage(int damage)
    {
        HP -= damage;

        if (HP <= 0)
        {
            HP = 0;
        }
    }
}