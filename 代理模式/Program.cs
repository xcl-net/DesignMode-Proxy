using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {

            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "娇娇";

            Proxy zhuiqiuzhe = new Proxy(jiaojiao);

            zhuiqiuzhe.GiveDolls();
            zhuiqiuzhe.GiveFlowers();
            zhuiqiuzhe.GiveChocolate();

            Console.Read();

        }
    }


    //“追求者”和“代理送花者”有同样的行为
    interface IGiveGift
    {
        void GiveDolls();//洋娃娃
        void GiveFlowers();
        void GiveChocolate();

    }


    //追求者
    class Pursuit:IGiveGift
    {
        private SchoolGirl mm;

        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }
    }

    //代理人
    class Proxy:IGiveGift
    {
        private Pursuit gg;

        public Proxy(SchoolGirl mm)
        {
            Console.WriteLine("代理人启动...");
            this.gg=new Pursuit(mm);
        }

        public void GiveDolls()
        {
           gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }

        public void GiveChocolate()
        {
          gg.GiveChocolate();
        }
    }

    class SchoolGirl
    {
        public string Name { get; set; }
    }
}
