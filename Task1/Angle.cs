using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value % 360;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value > 0 || value < 60)
                {
                    min = value;
                }
                else
                {
                    min = -1;
                }
            }
        }
        public int Sec
        {
            get
            {
                return Sec;
            }
            set
            {
                if (value > 0 || value < 60)
                {
                    sec = value;
                }
                else
                {
                    sec = -1;
                }
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRadians()
        {
            if (min == -1 || sec == -1)
            {
                return -1;
            }
            else
            {
                return (gradus + (min + (double)sec / 60) / 60) * Math.PI / 180;
            }
        }
    }
}