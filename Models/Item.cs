using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Newtonsoft.Json;

namespace DemoAcculynx.Models
{
    public class Item
    {

        public string[] tags { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public string is_answered { get; set; }

        public string  is_accepted { get; set; }

        public string question_id { get; set; }
        public string creation_date { get; set; }



    }
}
