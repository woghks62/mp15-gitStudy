using System;
using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        Slime slime = new Slime();  
        slime.Name = "슬라임";  
        slime.Hp = 20;
        
        slime.Attack();  
        slime.TakeDamage(5);
    }
}