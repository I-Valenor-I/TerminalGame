// See https://aka.ms/new-console-template for more information
using System;

public class Hero {
    public string Name {get; set;} = "Hero";
    public string Position {get; set;} = "00";
    public float Health {get; set;} = 100;
    public float Damage {get; set;} = 5;
    public int Experience {get; set;} = 0;
    
    public Hero(string name, string position, 
                float health, float damage, 
                int experience)
                {
        Name = name;
        Position = position;
        Health = health;
        Damage = damage;
        Experience = experience;
    }



}

public class Monster {
    public string Monster_name {get; set;} = " ";
    public string Monster_Position {get; set;} = "00";
    public float Monster_Health {get; set;} = 0;
    public float Monster_Damage {get; set;} = 0;
    public int Experience_value {get; set;} = 0;

    public static void Attack(float Monster) {
        Console.WriteLine("Attack");
    }


}

public class Slime : Monster {
    public string slime = "Slime";
    public string slimePosition = "00";
    public float slimeHealth = 15;
     public static float slimeDamage = 2;
    public int slimeXPValue = 5;
}

class Program {
    static void Main(){
        Hero hero1 = new Hero("Hero", "00", 100, 5, 0);

        Console.WriteLine($"Name: {hero1.Name}\nPosition: {hero1.Position}\nHealth: {hero1.Health}\nDamage: {hero1.Damage}\nXP {hero1.Experience}");
        Slime.Attack(Slime.slimeDamage = 3 );
        //Console.WriteLine(Slime.slimeDamage);
    }
}