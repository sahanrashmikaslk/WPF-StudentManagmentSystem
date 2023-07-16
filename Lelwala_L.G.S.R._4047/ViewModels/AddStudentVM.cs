using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace Lelwala_L.G.S.R._4047.ViewModels
{
    public partial class AddStudentVM : ObservableObject
    {
        [ObservableProperty]
        public int regNo;
        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;
        [ObservableProperty]
        public DateTime birthday;
        [ObservableProperty]
        public BitmapImage profilePicture;
        [ObservableProperty]

        public string profilePictureURL;
        [ObservableProperty]
        public double gpa;
        [ObservableProperty]
        public string city;

        [RelayCommand]
        public void InsertPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files | *.bmp; *.png; *.jpg";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                ProfilePicture = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
    }
}
