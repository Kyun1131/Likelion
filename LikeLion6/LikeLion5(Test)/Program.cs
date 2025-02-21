using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion5_Test_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 로아 캐릭터 정보 만들기
            int att = 151681;
            int maxHp = 299128;

            // 전투특성 치, 특, 신, 제, 인, 숙
            int crit = 665, specialization = 1795, domination = 79, swiftness = 77, endurance = 69, expertise = 75;

            // 출력
            Console.WriteLine("----------기본 특성----------");
            Console.WriteLine("공격력: "+att);
            Console.WriteLine("최대 생명력: "+maxHp);
            Console.WriteLine("\r\n----------전투 특성----------");
            Console.WriteLine("치명"+crit);
            Console.WriteLine("특화"+ specialization);
            Console.WriteLine("제압"+ domination);
            Console.WriteLine("신속"+ swiftness);
            Console.WriteLine("인내"+ endurance);
            Console.WriteLine("숙련"+ expertise); 


        }
    }
}
