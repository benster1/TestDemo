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

    }
}
