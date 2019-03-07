using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Request
    {
        /// <summary>
        /// 申请类型
        /// </summary>
        public string RequestType { get; set; }

        /// <summary>
        /// 申请内容
        /// </summary>
        public string RequestContent { get; set; }


        /// <summary>
        /// 申请数量
        /// </summary>
        public int Number { get; set; }
    }
}
