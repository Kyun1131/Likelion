using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Field
    {
        Player m_pPlayer = null;
        // 몬스터
        Monster m_pMonster = null;

        // 플레이어 MainGame에서 생성한거 가지고 오기
        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }


        public void Progress()
        {
            // 사냥터 입장
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                if (iInput <= 3)
                {

                    CreateMonster(iInput);
                    Fight();
                }
            }
        }

        public void Create(string _strName, int _ihp, int _iAtteck, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iHp = _ihp;
            tMonster.iAttack = _iAtteck;

            pMonster.SetMonster(tMonster);
        } 


        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("하수", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("중수", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("고수", 90, 9, out m_pMonster);
                    break;

            }
        }

        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }
                }

                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }




        public void DrawMap()
        {
            Console.WriteLine("1.하수");
            Console.WriteLine("2.중수");
            Console.WriteLine("3.고수");
            Console.WriteLine("4.뒤로가기");
            Console.WriteLine("=============");
        }

        public Field() { }
        ~Field() { }
    }
}
