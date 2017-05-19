using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class UintStatistic
    {
        public double? PresentShares{ get; set;}

        public double? AgreeShares { get; set; }

        public double? AgreeCount { get; set; }

        public double? DisagreeShares { get; set; }

        public double? DisagreeCount { get; set; }

        public double? NonShares { get; set; }

        public double? NonCount { get; set; }

        public double? AgreeRate { get; set; }

        public string AgreeRateFormatted
        {
            get
            {
                if (this.AgreeRate == null)
                {
                    return "0%";
                }
                else
                {
                    //修复字符串位数不够的问题
                    try
                    {
                        return (this.AgreeRate * 100).ToString().Substring(0, 6) + "%";
                    }
                    catch (Exception)
                    {
                        return (this.AgreeRate * 100) + "%";
                    }
                }
            }
        }

        public double? DisagreeRate { get; set; }

        public string DisagreeRateFormatted
        {
            get
            {
                if (this.DisagreeRate == null) return "0%";
                else
                {
                    try
                    {
                        return (this.DisagreeRate * 100).ToString().Substring(0, 6) + "%";
                    }
                    catch (Exception)
                    {
                        return (this.DisagreeRate*100) + "%";
                    }
                    //return (this.DisagreeRate * 100).ToString().Substring(0, 6) + "%";
                    //var t1 = double.Parse((this.DisagreeRate * 10000000).ToString().Substring(0, 6));
                    //return (t1 / 100000) + "%";
                    //return (this.DisagreeRate * 100).ToString().Substring(0, 6) + "%";
                }
            }
        }

        public double? NonRate { get; set; }

        public string NonRateFormatted
        {
            get
            {
                if (this.NonRate == null) return "0%";
                else
                {
                    try
                    {
                        return (this.NonRate * 100).ToString().Substring(0, 6) + "%";
                    }
                    catch (Exception)
                    {
                        return (this.NonRate * 100) + "%";
                    }
                    //var t1 = double.Parse((this.NonRate * 10000000).ToString().Substring(0, 6));
                    //return (t1 / 100000) + "%";
                    //return (this.NonRate * 100).ToString().Substring(0, 6) + "%";
                }
            }
        }
    }
}