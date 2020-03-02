using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorAppTeo.Models
{
    public enum AudioItemType
    {
        Audio0,
        Audio1,
        Audio2,
        Audio3,
        Audio4,
        Audio5,
        Audio6,
        Audio7,
        Audio8,
        Audio9,
        Audio10,
        Audio11,
        Audio12,
        Audio13,
        Audio14,
        Audio15,
        Audio16,
        Audio17,
        Audio18,
    }

    public class AudioMenuItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Duration { get; set; }

        public double Seconds { get; set; }

        public string URL { get; set; }
    }
}
