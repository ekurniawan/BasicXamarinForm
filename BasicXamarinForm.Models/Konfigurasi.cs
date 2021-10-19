using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarinForm.Models
{
    public class Konfigurasi
    {
        public string username { get; set; }
        public string token { get; set; }
        public DateTime expirationdate { get; set; }
        public int brightnes { get; set; }
    }
}
