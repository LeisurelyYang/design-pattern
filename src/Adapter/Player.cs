using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 相当于Target
    /// </summary>
    public abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();

        public abstract void Defense();
    }

    public class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"前锋 {name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋 {name} 防守");
        }
    }

    //中锋
    public class Center : Player
    {
        public Center(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"中锋 {name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"中锋 {name} 防守");
        }
    }

    //后卫
    public class Guards : Player
    {
        public Guards(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"后卫 {name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"后卫 {name} 防守");
        }
    }

    public class ForeignCenter
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public void 进攻()
        {
            Console.WriteLine($"外籍中锋 {name} 进攻");
        }

        public void 防守()
        {
            Console.WriteLine($"外籍中锋 {name} 防守");
        }
    }
}
