using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Lelwala_L.G.S.R._4047
{
    public class Student
    {
        public int RegNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public BitmapImage ProfilePicture { get; set; }

        public string ProfilePictureURL { get; set; }
        public double GPA { get; set; }    
        public string City { get; set; }
        public SeriesCollection Series { get; set; } // 8***********

       
    }
}
