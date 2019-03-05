using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="c"></param>
        public abstract void Add(Company c);

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="c"></param>
        public abstract void Remove(Company c);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="depth">显示层次</param>
        public abstract void Display(int depth);

        /// <summary>
        ///旅行职责
        /// </summary>
        public abstract void LineOfDuty();
    }
}
