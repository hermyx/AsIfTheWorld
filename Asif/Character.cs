using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asif
{
    class Character
    {
        public static Random rand = new Random();
        public char _gender
        {
            get;
            set;
        }
        public String _name
        {
            get;
            set;
        }
        public int _age
        {
            get;
            set;
        }
        public int _speed
        {
            get;
            set;
        }
        public int _strength
        {
            get;
            set;
        }
        public int _constitution
        {
            get;
            set;
        }
        public int _tiredness
        {
            get;
            set;
        }
       
        
        public String _skill; //(électricien, serrurier, boucher, etc. A voir pour en mettre plusieurs)

        public override String ToString()
        {
            String ret = "Name : " + _name + " - Age : " + _age + " - Gender : " + _gender + 
                "\nCharacteristics : Strength :" + _strength + " - Constitution :" + _constitution
                + " - Speed :" + _speed + " - Tiredness :" + _tiredness + 
                "\nSkills :" + _skill;
            return ret;
        }

        public String randName(char c){
            if(_gender == 'f') return "Sarah";
            if(_gender == 'm') return "Chuck";
            return "Toto";
        }

        //Constructors

        public Character()
        {
            int gender = rand.Next(2);
            if(gender == 0) _gender = 'f';
            if(gender == 1) _gender = 'm';
            //Random gender
            _name = randName(_gender);
            //Random name
            Thread.Sleep(1);
            int age = rand.Next(70);
            _age = age;
            //Random age
            int bonus_st = 0, bonus_sp = 0;
            if (_gender=='m'){
                bonus_st = 10;
                bonus_sp = -10;
            }
            int strength = rand.Next(10);
            _strength = 10 + bonus_st + strength;
            //Strength = 10(+10)//20(+10)
            int speed = rand.Next(10);
            _speed = 20 + bonus_sp + speed;
            //Speed = 20(+10)//10(+10)
            _constitution = strength+speed;
            //Constitution = Muscle ?
            _tiredness = 0;
            _skill = "NoneForNow";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans As If The World Wasn't Ending !");
            int c =0;
            HashSet<Character> list_char = new HashSet<Character>();
            while (c++ < 6)
            {list_char.Add(new Character());
            }
            foreach (Character chara in list_char)
            {
                Console.WriteLine(chara.ToString());
            }
            Console.WriteLine("Toto");
        }
    }

        
}
