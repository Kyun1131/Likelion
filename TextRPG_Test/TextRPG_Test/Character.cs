using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextRPG_Test
{
    public abstract class Character
    {
        public string Name;
        public int Hp;
        public int MaxHp;
        public int Attack;

        public Character(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            MaxHp = hp;
            Attack = attack;
        }

        public void TakeDamage(int damage) => Hp -= damage;
        public bool IsAlive() => Hp > 0;
        public void Heal(int amount) => Hp = Math.Min(Hp + amount, MaxHp);

        public void Render()
        {
            Console.WriteLine($"[{Name}] HP: {Hp}/{MaxHp} | 공격력: {Attack}");
        }








    }




}
