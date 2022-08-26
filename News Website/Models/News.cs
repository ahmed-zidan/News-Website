using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace News_Website.Models
{
    public class News
    {

        public int Id { get; set; }
        public string Titley { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
    }
}
