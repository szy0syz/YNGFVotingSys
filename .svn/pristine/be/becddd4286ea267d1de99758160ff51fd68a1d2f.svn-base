using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataService;

namespace WebAPI.Controllers
{
    public class SettingsController : ApiController
    {
        // GET: api/Settings
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Settings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Settings
        public string Post(Models.SettingView model)
        {
            //检查model合法性 
            if (model != null)
            {
                var db = new SZYdbEntities();
                DataService.Settings setting = null;
                if (model.TypeCode == "General")
                {
                    setting = db.Settings.FirstOrDefault(s => s.TypeCode == model.TypeCode && s.SettingKey == model.SettingKey);
                    if (setting != null)
                    {
                        setting.SettingValue = model.SettingValue;
                        db.SaveChanges();
                        return "设置成功 [General_" + model.SettingKey + "]";
                    }
                    else
                    {
                        return "没有找到设置对象[General_"+ model.SettingKey +"]";
                    }
                }
                if(model.TypeCode == "Other")
                {
                    switch (model.SettingKey)
                    {
                        case "ClearOnePresent":
                            var d = db.Shares.FirstOrDefault(s => s.BarCode == model.SettingValue);
                            if (d != null)
                            {
                                d.IsPresent = false;
                                db.SaveChanges();
                                return "已清除股东["+ d.Name + "]个签到标识";
                            }
                            else
                            {
                                return "没有找到设置对象[ClearOnePresent]";
                            }
                            //break;
                        case "ClearAllPresent":
                            var shareList = db.Shares.Where(s => s.Enable == true);
                            foreach (var item in shareList)
                            {
                                item.IsPresent = false;                               
                            }
                            db.SaveChanges();
                            return "已清除所有股东的签到标识";
                        //break;
                        case "ClearAllVoted":
                            var shareList0 = db.Shares.Where(s => s.Enable == true);
                            foreach (var item in shareList0)
                            {
                                item.IsVoted = false;
                            }
                            db.SaveChanges();
                            return "已清除所有股东的表决标识";
                    }
                }
                return "统一设置完成";
            }
            else
            {
                return "提交数据不合法";
            }
            
        }

        // PUT: api/Settings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Settings/5
        public void Delete(int id)
        {
        }
    }
}
