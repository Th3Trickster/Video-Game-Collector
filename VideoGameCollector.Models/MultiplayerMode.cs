using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    public class MultiplayerMode
    {
        public int id { get; set; }
        public bool campaigncoop { get; set; }
        public bool dropin { get; set; }
        public bool lancoop { get; set; }
        public bool offlinecoop { get; set; }
        public int offlinecoopmax { get; set; }
        public int offlinemax { get; set; }
        public bool onlinecoop { get; set; }
        public int onlinecoopmax { get; set; }
        public int onlinemax { get; set; }
        public Platform platform { get; set; }
        public bool splitscreen { get; set; }
        public bool splitscreenonline { get; set; }
    }
}
