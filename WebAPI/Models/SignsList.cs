using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class SignsList
    {
        public string BarCode { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }


        public SignsList ToPoco()
        {
            return new SignsList()
            {
                BarCode = this.BarCode,
                Name = this.Name,
                Time = this.Time
            };
        }
    }
}