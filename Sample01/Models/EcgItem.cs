using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Models
{
    public class EcgItem
    {
        /// <summary>
        /// 心电项目id
        /// </summary>
        public int EcgItemId { get; set; }

        /// <summary>
        /// 心电项目编码
        /// </summary>
        public string ItemNo { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string Pym { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string ItemUnit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 五笔码
        /// </summary>
        public string Wbm { get; set; }

        /// <summary>
        /// 助记码
        /// </summary>
        public string InputCode { get; set; }

        /// <summary>
        /// 系统类别
        /// </summary>
        public string SysClass { get; set; }

        /// <summary>
        /// 默认科室编码
        /// </summary>
        public string ExecDept { get; set; }

        /// <summary>
        /// 专业组
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>

        public DateTime OperTime { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// 是否常用
        /// </summary>
        public bool CommomUse { get; set; }
    }
}
