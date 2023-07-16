using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lelwala_L.G.S.R._4047.Views;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lelwala_L.G.S.R._4047
{
    public partial class MainWindowVM : ObservableObject
    {
        private string Color2 = "#349DBE";
        private string Color1 = "#eb392d";


        [ObservableProperty]
        public SeriesCollection seriesCollection2;
        [ObservableProperty]
        public ObservableCollection<Student> students;
        [ObservableProperty]
        public Student selectedStudent;

        [ObservableProperty]
        public string greeting;

        [ObservableProperty]
        public string loginName;
        [ObservableProperty]
        public string loginOccupation;

        WindowMaker windowmaker;

        public MainWindowVM()
        {
            students = new ObservableCollection<Student>();
            Students.Add(new Student()
            {
                RegNo = 1,
                FirstName = "Taylor",
                LastName = "Swift",
                City = "New York",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL ="/Icons/Taylor.jpg",

                Series = new SeriesCollection
            {
                new PieSeries
                {
                   Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color1)),
                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(3.8)) },
                    DataLabels = false

                },
                new PieSeries
                {

                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(0.2)) },
                    Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color2)),

                    DataLabels= false
                }

            }

            });
            Students.Add(new Student()
            {
                RegNo = 2,
                FirstName = "Ariana",
                LastName = "Grande",
                City = "California",
                GPA = 2.8,
                Birthday = DateTime.Parse("01/01/1997")
                ,
                ProfilePictureURL = "/Icons/Ariana.jpeg",
                Series = new SeriesCollection
            {
                new PieSeries
                {
                   Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color1)),
                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(2.8)) },
                    DataLabels = false

                },
                new PieSeries
                {

                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(4-2.8)) },
                    Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color2)),

                    DataLabels= false
                }

            }

            });
            Students.Add(new Student()
            {
                RegNo = 3,
                FirstName = "Selena",
                LastName = "Gomez",
                City = "Texas",
                GPA = 3.8,
                Birthday = DateTime.Parse("02/02/1985"),
                ProfilePictureURL = "/Icons/Selena.jpg",

                Series = new SeriesCollection
            {
                new PieSeries
                {
                   Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color1)),
                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(3.8)) },
                    DataLabels = false

                },
                new PieSeries
                {

                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(0.2)) },
                    Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color2)),

                    DataLabels= false
                }

            }

            }); Students.Add(new Student()
            {
                RegNo = 4,
                FirstName = "Justin",
                LastName = "Swift",
                City = "New York",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL = "/Icons/Stephen.jpg",

                Series = new SeriesCollection
            {
                new PieSeries
                {
                   Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color1)),
                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(3.8)) },
                    DataLabels = false

                },
                new PieSeries
                {

                    Values = new ChartValues<ObservableValue> { new ObservableValue(GpaToPercentage(0.2)) },
                    Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Color2)),

                    DataLabels= false
                }

            }

            }); Students.Add(new Student()
            {
                RegNo = 1,
                FirstName = "Taylor",
                LastName = "Swift",
                City = "New York",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL = "/Icons/Taylor.jpg",
            }); Students.Add(new Student()
            {
                RegNo = 1,
                FirstName = "Taylor",
                LastName = "Swift",
                City = "New York",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL = "/Icons/Ariana.jpg",
            }); Students.Add(new Student()
            {
                RegNo = 1,
                FirstName = "Selena",
                LastName = "Gomez",
                City = "Texas",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL = "/Icons/Selena.jpg",
            }); Students.Add(new Student()
            {
                RegNo = 1,
                FirstName = "Taylor",
                LastName = "Swift",
                City = "New York",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL = "/Icons/Stephen.jpg",
            }); Students.Add(new Student()
            {
                RegNo = 1,
                FirstName = "Taylor",
                LastName = "Swift",
                City = "New York",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL = "/Icons/Stephen.jpg",
            }); Students.Add(new Student()
            {
                RegNo = 1,
                FirstName = "Taylor",
                LastName = "Swift",
                City = "New York",
                GPA = 3.8,
                Birthday = DateTime.Parse("01/01/1999"),
                ProfilePictureURL = "/Icons/Stephen.jpg",
            });
            loginName = "Stephen";
            loginOccupation = "Lecturer";
            SetGreeting();

            /*SeriesCollection2 = new SeriesCollection
            {
                new PieSeries
                {
                   Fill = new SolidColorBrush(Colors.Blue),
                    Values = new ChartValues<ObservableValue> { new ObservableValue(25) },
                    DataLabels = false


                },
                new PieSeries
                {

                    Values = new ChartValues<ObservableValue> { new ObservableValue(75) },
                   Fill = new SolidColorBrush(Colors.Pink),
        DataLabels= false
                },

            };*/
            windowmaker = new WindowMaker();

        }



        private double GpaToPercentage(double gpa)
        {
           
                return (gpa / 4.0) * 100;
            
        }
        private void SetGreeting()
        {
            var date = DateTime.Now;
            int hour = date.Hour;
            if (hour <= 11)
                Greeting = "Good morning," + " " + loginName;
            else if (hour <= 17)
                Greeting = "Good afternoon," + " " + loginName;
            else
                Greeting = "Good evening," + " " + loginName;
        }

        [RelayCommand]
        public void AddStudent()
        {
            windowmaker.CreateAddStudent();
        }

        [RelayCommand]
        public void EditStudent()
        {
            windowmaker.CreateEditStudent();    
        }
    }

    public class WindowMaker
    {
        public void CreateAddStudent()
        {
            AddStudent addStudentWindow = new AddStudent();
            addStudentWindow.Show();
        }

        public void CreateEditStudent()
        {
            EditStudent editStudentWindow = new EditStudent();
            editStudentWindow.Show();
        }
    }
}
