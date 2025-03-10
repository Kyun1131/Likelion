﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_03_06_1_3
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }


        protected GameCharacter(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }


        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - Defense);

            Health = Math.Max(0, Health - actualDamage);

            Console.WriteLine($"{Name}이 {actualDamage}의 피해를 받았습니다. 남은체력 : {Health}");

        }




    }
}
