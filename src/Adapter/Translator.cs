using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //翻译者（适配器）
    public class Translator : Player
    {
        private ForeignCenter wjzf = new ForeignCenter();
        public Translator(string name)
            : base(name)
        {
            wjzf.Name = name;
        }
        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
