using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Srt
{
    public class Caption
    {

        public bool isFilled;
        private int fromHours, fromMinutes, fromSeconds, fromMilliseconds;
        private int toHours, toMinutes, toSeconds, toMilliseconds;
        private string second, third;

        public Caption()
        {
            isFilled = false;
        }
        public int FromHours
        {
            get
            {
                return fromHours;
            }
            set
            {
                if (value >= 0 && value <= 24)
                    fromHours = value;
            }
        }
        public int FromMinutes
        {
            get
            {
                return fromMinutes;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    fromMinutes = value;
            }
        }
        public int FromSeconds
        {
            get
            {
                return fromSeconds;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    fromSeconds = value;
            }
        }
        public int FromMilliseconds
        {
            get
            {
                return fromMilliseconds;
            }
            set
            {
                if (value >= 0 && value <= 999)
                    fromMilliseconds = value;
            }
        }

        public int ToHours
        {
            get
            {
                return toHours;
            }
            set
            {
                if (value >= 0 && value <= 24)
                    toHours = value;
            }
        }
        public int ToMinutes
        {
            get
            {
                return toMinutes;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    toMinutes = value;
            }
        }
        public int ToSeconds
        {
            get
            {
                return toSeconds;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    toSeconds = value;
            }
        }

        public int ToMilliseconds
        {
            get
            {
                return toMilliseconds;
            }
            set
            {
                if (value >= 0 && value <= 999)
                    toMilliseconds = value;
            }
        }

        public string Second
        {
            get { return second; }
            set { second = value; }
        }

        public string Third
        {
            get { return third; }
            set { third = value; }
        }
    }
}
