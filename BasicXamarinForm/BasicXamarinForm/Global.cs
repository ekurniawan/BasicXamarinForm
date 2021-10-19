using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarinForm
{
    public class Global
    {
        public Global(){}
        private static Global _instance;
        public static Global Instance
        {
            get {
                if(_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }
        public string Username { get; set; }
        public string Address { get; set; }
    }
}
