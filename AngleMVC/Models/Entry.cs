using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngleMVC.Models
{
    public class Entry
    {
        [Display(Name = "Godzina: (w formacie 00:00)")]
        public string Time { get; set; }
    }
}