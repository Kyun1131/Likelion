﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Monster
    {
        public INFO m_tMonster; // 몬스터 데이터

        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; }
        public void SetMonster(INFO tMonster) { m_tMonster= tMonster;}
        public INFO GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "\t공격력 :  " + m_tMonster.iAttack);
        }

        public Monster() { } // 기본 생성
        ~Monster() { } // 소멸자
    }
}
