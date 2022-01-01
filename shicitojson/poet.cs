using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shicitojson
{
    /// <summary>
    /// 诗人
    /// </summary>
    internal class poet
    {
        /// <summary>
        /// 诗人的id
        /// </summary>
        public string poetid { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 朝代
        /// </summary>
        public string dynasty { get; set; }

        /// <summary>
        /// 诗歌id
        /// </summary>
        public List<string> poemIds { get; set; }
    }
}

