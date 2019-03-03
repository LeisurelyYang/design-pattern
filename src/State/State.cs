using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    /// <summary>
    /// 状态模式基础抽象类
    /// </summary>
    public abstract class State
    {
        /// <summary>
        /// 写程序抽象方法
        /// </summary>
        public abstract void WriteProgram(Work w);
    }

    /// <summary>
    /// 上午的工作状态
    /// </summary>
    public class ForenoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine($"当前时间:{w.Hour}点 上午工作，精神百倍");
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }

    /// <summary>
    /// 中午的工作状态
    /// </summary>
    public class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine($"当前时间:{w.Hour}点 饿了，午饭，犯困，午休");
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }

    /// <summary>
    /// 下午和傍晚的工作状态
    /// </summary>
    public class AfternoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine($"当前时间:{w.Hour}点 下午状态还不错，继续努力");
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }

    /// <summary>
    /// 晚间的工作状态
    /// </summary>
    public class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new ResetState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine($"当前时间:{w.Hour}点 加班哦，疲惫至极");
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }

    /// <summary>
    /// 睡眠状态
    /// </summary>
    public class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine($"当前时间:{w.Hour}点 不行了，睡着了 ");
        }
    }

    /// <summary>
    /// 下班休息状态
    /// </summary>
    public class ResetState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine($"当前时间:{w.Hour}点 下班回家了 ");
        }
    }
}
