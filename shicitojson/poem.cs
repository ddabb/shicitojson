using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shicitojson
{
    /// <summary>
    /// 诗歌
    /// </summary>
    internal class poem
    {
        /// <summary>
        /// 诗歌id
        /// </summary>
        public string poemid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        
        /// <summary>
        /// 正文内容
        /// </summary>
        public List<string> contents { get; set; }

        /// <summary>
        /// 诗歌类型
        /// </summary>
        public string ptype { get; set; }
    }
}
