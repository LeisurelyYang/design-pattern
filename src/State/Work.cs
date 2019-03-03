using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Work
    {
        private State current;
        public Work()
        {
            current = new ForenoonState();
        }
        /// <summary>
        /// 工作时间
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// 任务是否完成
        /// </summary>

        public bool TaskFinished { get; set; }

        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
