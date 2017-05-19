using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public partial class AdminView
    {
        /// <summary>
        /// 初始化构造函数
        /// </summary>
        /// <param name="list"></param>
        public AdminView(List<VotedList> list)
        {
            this.VotedList = list;
        }

        /// <summary>
        /// 所有股东数量
        /// </summary>
        public int TotalShareholders => this.VotedList.Count();

        /// <summary>
        /// 所有实到股东数量
        /// </summary>
        public int TotalPresentShareholders => this.VotedList.Count(s => s.IsPresent == true);

        /// <summary>
        /// 已投票的实到股东数量
        /// </summary>
        public int VotedSahreholders => this.VotedList.Count(s => s.IsVoted == true);

        /// <summary>
        /// 还没投票的实到股东数量
        /// </summary>
        public int NoVotedSahreholders => this.TotalPresentShareholders - this.VotedSahreholders;

        /// <summary>
        /// 表决结果列表
        /// </summary>
        public List<VotedList> VotedList { get; set; }

    }
}