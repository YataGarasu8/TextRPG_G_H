// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG
{
    public class Item
    {
        private static Item item = new Item();

        public Weapon weapon = new Weapon();
    }

    public class Weapon
    {
        public string[,] Sword;
        public int[,] GoldStauts;


        public Weapon() //상속을 이용해서 하위 클래스로 작성하는 게 더 좋았을지도
        {
            Sword = new string[13, 3];
            GoldStauts = new int[13, 3];

            Sword[0, 0] = "초심자의 직검";
            Sword[1, 0] = "초보 도적의 단검";
            Sword[2, 0] = "풋내기 백정의 식칼";
            Sword[3, 0] = "단조 강철검";
            Sword[4, 0] = "은단검";
            Sword[5, 0] = "도금된 도축칼";
            Sword[6, 0] = "천조국의 휘장검";
            Sword[7, 0] = "침략자의 시미터";
            Sword[8, 0] = "왜구의 카타나";
            Sword[9, 0] = "도망자의 쌍검";
            Sword[10, 0] = "야만전사의 대검";
            Sword[11, 0] = "EX칼리버";
            Sword[12, 0] = "카드라는 이름의 검";

            Sword[0, 1] = "공격력 +1 방어력 +1";
            Sword[1, 1] = "공격력 +1";
            Sword[2, 1] = "공격력 +2 방어력 -1";
            Sword[3, 1] = "공격력 +3 방어력 +4";
            Sword[4, 1] = "공격력 +7 방어력 +1";
            Sword[5, 1] = "공격력 +5 방어력 -2";
            Sword[6, 1] = "공격력 +10 방어력 +10";
            Sword[7, 1] = "공격력 +8 방어력 +5";
            Sword[8, 1] = "공격력 +9 방어력 +2";
            Sword[9, 1] = "공격력 +6 방어력 -2";
            Sword[10, 1] = "공격력 +15 방어력 -8";
            Sword[11, 1] = "공격력 +20 방어력 +20";
            Sword[12, 1] = "공격력 +40";

            Sword[0, 2] = "초보 전사들이 쓰는 검";
            Sword[1, 2] = "초보 도적들이 쓰는 단검";
            Sword[2, 2] = "미숙한 백정이나 쓰는 무딘 식칼이다.";
            Sword[3, 2] = "평범한 강철검이다.";
            Sword[4, 2] = "의식에서 쓰는 제례용 단검. 특별 제작하기에 시중에서는 보기 힘들다.";
            Sword[5, 2] = "동물을 해체하기 위한 도축칼. 약간 스산한 기운이 서려있다.";
            Sword[6, 2] = "천조국에서는 국가에 헌신한 자들을 위해 검으로 명예를 전한다고 한다.";
            Sword[7, 2] = "신의 이름을 전하기 위해 전도자들이 썼다는 시미터. 그러나 원주민에게 그들은 잔혹한 침략자였다.";
            Sword[8, 2] = "섬나라에서 무사들에게 쓰여진 칼. 하지만 무사의 명예는 땅에 떨어져 약탈의 도구가 되었다.";
            Sword[9, 2] = "갈 곳 없는 자들의 호신 도구. 유일한 생명줄은 과연 호신을 위해서만 쓰였을까.";
            Sword[10, 2] = "야만전사들 필수품. 없으면 야만전사라 칭할 수 없다.";
            Sword[11, 2] = "전설의 검. 누가 감히 왕의 상징에 거역할쏘냐";
            Sword[12, 2] = "듀얼로 결착을 내자";

            GoldStauts[0, 0] = 5;
            GoldStauts[1, 0] = 5;
            GoldStauts[2, 0] = 5;
            GoldStauts[3, 0] = 1300;
            GoldStauts[4, 0] = 2100;
            GoldStauts[5, 0] = 1800;
            GoldStauts[6, 0] = 10000;
            GoldStauts[7, 0] = 5000;
            GoldStauts[8, 0] = 3000;
            GoldStauts[9, 0] = 1100;
            GoldStauts[10, 0] = 5500;
            GoldStauts[11, 0] = 50000;
            GoldStauts[12, 0] = 39800;

            GoldStauts[0, 1] = 1;//변환에서 오류나는 게 짜증나서 그냥 따로 뺌
            GoldStauts[1, 1] = 1;
            GoldStauts[2, 1] = 2;
            GoldStauts[3, 1] = 3;
            GoldStauts[4, 1] = 7;
            GoldStauts[5, 1] = 5;
            GoldStauts[6, 1] = 10;
            GoldStauts[7, 1] = 8;
            GoldStauts[8, 1] = 8;
            GoldStauts[9, 1] = 6;
            GoldStauts[10, 1] = 15;
            GoldStauts[11, 1] = 20;
            GoldStauts[12, 1] = 40;

            GoldStauts[0, 2] = 1;//방어구도 따로 구현해서 하나씩만 장비하게 할 수 있을지도?
            GoldStauts[1, 2] = 0;
            GoldStauts[2, 2] = -1;
            GoldStauts[3, 2] = 4;
            GoldStauts[4, 2] = 1;
            GoldStauts[5, 2] = -2;
            GoldStauts[6, 2] = 10;
            GoldStauts[7, 2] = 5;
            GoldStauts[8, 2] = 2;
            GoldStauts[9, 2] = -2;
            GoldStauts[10, 2] = -8;
            GoldStauts[11, 2] = 20;
            GoldStauts[12, 2] = 0;

        }
    }

}
