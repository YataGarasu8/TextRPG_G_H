// See https://aka.ms/new-console-template for more information

//전체 주석화: 드래그 + Ctrl + K + C
//전체 주석화 해제: 드래그 + Ctrl + K +U
//전체 줄 정리: Ctrl + K + Ctrl + D


using System.Threading;
using DungeonTRPG;
using System.Xml.Linq;

namespace DungeonTRPG
{

    public class DungeonGame
    {
        public static Character character = new Character();
        public static Item item = new Item();
        public static Dungeon dungeon = new Dungeon();
        public static UI ui = new UI();

        public static string? name; //요 이름 선언하는 것만 아니었으면 전부 다른 스크립트로 빼고 싶었는데...
        public static string[,] items = new string[10, 2];//보유 아이템
        public static string[] equip = new string[10]; //장비템. 스텟에 반영될 아이템의 배열 


        static void Main()
        {
            bool nameLength = false;
            bool Trues = false;
            //Character character = new Character();

            Console.Write("의문의 노인: 스파르타 던전 클럽에 온 것을 환영한다. 자네의 이름을 알려주게?\n이름: ");

            while (!nameLength)
            {
                name = Console.ReadLine();
                if (name.Length <= 6 && name.Length >= 1)
                {

                    Console.WriteLine("의문의 노인: 그게 자네 이름이 맞는가? \n1. 네\n2. 아니요");
                    string p = Console.ReadLine();
                    if (p == "2" || p == "1")//예외 처리 필요
                    {
                        switch (p)
                        {
                            case "1":
                                Console.WriteLine($"의문의 노인: 흠. {name}(이)라고 하는 가. \n");
                                nameLength = true;
                                break;
                            case "2":
                                Console.Write("의문의 노인: 그럼 다시 말해주게\n이름 :");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    { Console.Write("의문의 노인:으음? 다시 말해주게\n이름 :"); }
                }
                else
                {
                    Console.Write("의문의 노인: 뭐라고? 잘 못 들었네. 여섯 글자 이내로 다시 말해주게. \n이름 :");
                }
            }
            Console.WriteLine("의문의 노인: 여기 던전 클럽에서는 누구나 직업을 갖고 있지. \n다만 아무 직업이나 고를 수 없지. 이 키오스크로 자네가 원하는 직업을 골라주게." +
                "\n키오스크 : 삐빗. 직업을 골라 주세요. \n\n1 .전사\n2. 도적\n3. 백정");

            while (!Trues)
            {
                int p;
                string Cmd = Console.ReadLine();
                bool r = int.TryParse(Cmd, out p);
                if (r)
                {
                    if (p <= 3 && p >= 1)
                    {
                        Console.WriteLine("키오스크: 정말 그걸로 하시겠습니까? \n1. 네\n2. 아니요");
                        string q = Console.ReadLine();
                        if (q == "1")
                        {
                            switch (p)
                            {
                                case 1:
                                    Console.WriteLine("의문의 노인: 그럼 이제 부터 자네는 전사일세. 가장 평범한 직업이네 그려. 모든 스탯이 준수하지.\n");
                                    character.job = new Warrior(10, 10, 200, 1000, "전사");
                                    items[0, 0] = item.weapon.Sword[0, 0];
                                    Trues = true;
                                    break;
                                case 2:
                                    Console.WriteLine("의문의 노인: 그럼 이제 부터 자네는 도적일세. 공격을 제외한 스탯이 낮은 대신 내가 여비를 더 주도록 하지.\n");
                                    character.job = new Thief(9, 8, 180, 2000, "도적");
                                    items[0, 0] = item.weapon.Sword[1, 0];
                                    Trues = true;
                                    break;
                                case 3:
                                    Console.WriteLine("의문의 노인: 그럼 이제 부터 자네는 백정일세. 거참, 희안한 직업을 얻었구만. 공격력은 높지만 다른 건 기대하지 말게나.\n");
                                    character.job = new Butcher(20, 3, 200, 800, "백정");
                                    items[0, 0] = item.weapon.Sword[2, 0];
                                    Trues = true;
                                    break;
                                default:
                                    //Console.WriteLine("의문의 노인 :잘못 고른 것 같군. 다시 골라보게.");
                                    break;
                            }
                        }
                        else { Console.WriteLine("키오스크: 다시 선택해 주세요."); }
                    }
                    else
                    { Console.WriteLine("키오스크: 선택지에 없는 번호입니다."); }
                }
                else if (Cmd == "UUDDLRLRBA")
                {
                    Console.WriteLine("의문의 노인: 아니!? 자네는 듀얼리스트였군! 활약을 기대하겠네!\n");
                    character.job = new Duelist(25, 25, 100, 8000, "듀얼리스트");
                    items[0, 0] = item.weapon.Sword[12, 0];
                    Trues = true;
                }
                else
                {
                    Console.WriteLine("키오스크: 잘못된 선택입니다. 다시 선택해주세요.");
                }
            }
            Console.WriteLine("의문의 노인: 자, 이제 준비는 끝났네. 이제 자네는 던전에 들어갈 수 있고 상점도 이용할 수 있지." +
                "\n자네만의 방법으로 최종 던전 클리어를 노려 보게나. 그럼 이만.\n");

            UI.Window();
        }
    }

    public class UI : DungeonGame
    {
        private static int AtkAdd;
        private static int DefAdd;

        public static void Window()//다음에 하게 되면 이하 스크립트는 인터페이스를 이용해 작성하는 게 좋을 것 같다.
                                   //디버깅 시간이 긴 게 static 때문이었구나... 다음 부터는 최소한만 쓰도록 해야겠다. +메모리 낭비도 있었네
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n1. 스테이터스\n2. 장비창 보기\n3. 상점\n4. 던전 들어가기");
                string Ward = Console.ReadLine();
                Console.Clear();
                switch (Ward)
                {
                    case "1":
                        Stauts(name);
                        back = !back;
                        break;
                    case "2":
                        Inventory();
                        back = !back;
                        break;
                    case "3":
                        Shop();
                        back = !back;
                        break;
                    case "4":
                        dungeon.entrance.Enter(); 
                        back = !back;
                        break;
                    default:
                        Console.WriteLine("잘못 누르셨습니다.");
                        break;
                }
            }
        }
        public static void Stauts(string named)
        {
            AtkAdd = 0;
            DefAdd = 0;
            bool back = false;
            while (!back)//이러면 상태창 안 들어가면 스탯 반영이 안되나?
            {
                for (int i = 0; i < equip.Length; i++)//문자열 자체가 하나의 배열이니 당연히 Length를 선언할 수 있었는데... 너무 늦게 깨달았다.
                {
                    for (int j = 0; j < 13; j++) //어째서 여긴 Length를쓰면 범위를 넘어간다고 나오는 거지...?
                    {
                        if (equip[i] == item.weapon.Sword[j, 0])
                        {
                            AtkAdd += item.weapon.GoldStauts[j, 1];
                            DefAdd += item.weapon.GoldStauts[j, 2];
                        }
                    }
                }
                Console.WriteLine($"\n이름: {name} " +
                $"\n레벨: {character.job.Lv}" +
                $"\n직업: {character.job.Jobname}" +
                    $"\n공격력: {character.job.Atk + AtkAdd} ({AtkAdd})" +
                    $"\n방어력: {character.job.Def + DefAdd} ({DefAdd})" +
                $"\n체력: {character.job.HitP}" +
                    $"\n골드: {character.job.Gold}" +
                    $"\n\n0. 돌아가기");//가독성 때문에 줄내림

                string Ward = Console.ReadLine();

                Console.Clear();
                switch (Ward)
                {
                    case "0":
                        Window();
                        back = !back;
                        break;
                    default:
                        Console.WriteLine("잘못 누르셨습니다.");
                        break;
                }
            }
        }
        public static void Inventory()
        {
            bool back = false;
            while (!back)
            {
                int i;
                int j;
                Console.WriteLine("[인벤토리]\n");
                for (i = 0; items[i, 0] != null; i++)
                {
                    Console.Write($"{i + 1}. {items[i, 0]}{items[i, 1]}");
                    for (j = 0; j < 13; j++)
                    {
                        if (items[i, 0] == item.weapon.Sword[j, 0])
                        {
                            Console.WriteLine($"| {item.weapon.Sword[j, 1]} | {item.weapon.Sword[j, 2]}");
                        }
                    }
                }
                Console.WriteLine("\n0. 돌아가기");
                string Ward = Console.ReadLine();
                Console.Clear();
                bool r = int.TryParse(Ward, out j);

                if (r)
                {
                    if (j > 0 && j <= i)
                    {
                        for (int m = 0; m < equip.Length; m++)
                        {
                            if (items[j - 1, 0] == equip[m]) //오히려 하나만 장비 시키는 게 더 구현하기 쉬울지도
                            {
                                equip[m] = null;
                                items[j - 1, 1] = null;
                                break;
                            }
                            else if (equip[m] == null)
                            {
                                equip[m] = items[j - 1, 0];
                                items[j - 1, 1] = "[E]";
                                break;
                            }
                        }

                    }
                    else if (j == 0)
                    {
                        Window();
                        back = !back;
                    }
                    else if (j == 55)
                    {
                        Equip();
                        back = !back;
                    }
                    else
                    {
                        Console.WriteLine("잘못 누르셨습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("잘못 누르셨습니다.");
                }
            }
        }
        public static void Equip()//개발자 확인용 루트ㅋ
        {
            bool back = false;
            while (!back)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i + 1}. {equip[i]}");
                }
                Console.WriteLine("\n0. 돌아가기");
                string Ward = Console.ReadLine();
                Console.Clear();
                switch (Ward)
                {
                    case "0":
                        Inventory();
                        back = !back;
                        break;
                    default:
                        Console.WriteLine("잘못 누르셨습니다.");
                        break;
                }
            }
        }

        public static void Shop()
        {
            string[] sold = new string[3];
            bool back = false;
            Console.WriteLine("무기 상인: 손님이 왔구만! 마음 껏 골라 봐.\n");
            while (!back)
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine($"{i}. {item.weapon.Sword[2 + i, 0]} | {item.weapon.GoldStauts[2 + i, 0]} Gold | {item.weapon.Sword[2 + i, 1]} | {item.weapon.Sword[2 + i, 2]} | {sold[i - 1]}");
                }
                Console.WriteLine($"\n소지금: {character.job.Gold} Gold\n0. 돌아가기");
                string Ward = Console.ReadLine();
                Console.Clear();

                switch (Ward) //여기는 if문으로 바꾸는 게 더 깔끔할 듯
                {
                    case "0":
                        Window();
                        back = !back;
                        break;
                    case "1":
                        if (sold[0] == "판매 완료")
                        { Console.WriteLine("그건 이미 팔렸어. 다음 입고를 기대하라고.\n"); }
                        else if (item.weapon.GoldStauts[3, 0] <= character.job.Gold)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (items[i, 0] == null) { items[i, 0] = item.weapon.Sword[3, 0]; break; }
                            }
                            sold[0] = "판매 완료";
                            character.job.Gold -= item.weapon.GoldStauts[3, 0];
                            Console.WriteLine("평범하지만 좋은 검이지. 잘 쓰라고.\n");
                        }
                        else
                        { Console.WriteLine("이런, 돈이 없네. 한탕 더 뛰고 와.\n"); }
                        break;
                    case "2":
                        if (sold[1] == "판매 완료")
                        { Console.WriteLine("그건 이미 팔렸어. 다음 입고를 기대하라고.\n"); }
                        else if (item.weapon.GoldStauts[4, 0] <= character.job.Gold)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (items[i, 0] == null) { items[i, 0] = item.weapon.Sword[4, 0]; break; }

                            }
                            sold[1] = "판매 완료";
                            character.job.Gold -= item.weapon.GoldStauts[4, 0];
                            Console.WriteLine("은은 신성한 금속이라고 하는데 난 그런 건 모르겠어.\n");
                        }
                        else
                        { Console.WriteLine("이런, 돈이 없네. 한탕 더 뛰고 와.\n"); }
                        break;
                    case "3":
                        if (sold[2] == "판매 완료")
                        { Console.WriteLine("그건 이미 팔렸어. 다음 입고를 기대하라고,\n"); }
                        else if (item.weapon.GoldStauts[5, 0] <= character.job.Gold)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (items[i, 0] == null) { items[i, 0] = item.weapon.Sword[5, 0]; break; }
                            }
                            sold[2] = "판매 완료";
                            character.job.Gold -= item.weapon.GoldStauts[5, 0];
                            Console.WriteLine("그걸 원한다고? 거 취향 참...\n");
                        }
                        else
                        { Console.WriteLine("이런, 돈이 없네. 한탕 더 뛰고 와.\n"); }
                        break;
                    default:
                        Console.WriteLine("무기 상인: 그런 건 우리 가게에 없어.\n");
                        break;
                }
            }
        }
    }
}