using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 新增
        /// </summary>

        public abstract void Add(Component c);

        //移除
        public abstract void Remove(Component c);


        //展示
        public abstract void Display(int depth);
    }
}
