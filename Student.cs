using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Student
    {
        private string _name;
        private string _id;
        private int _birthYear;
        private int _height;
        private double _grade;
        private string _faculty;
        private string name;
        private string id;
        private double iYear;
        private int iheight;
        private double igrade;
        private string faculty;

        public Student(string name, string id, int birthYear, int height, double grade, string faculty)
        {
            this._name = name;
            this._id = id;
            this._birthYear = birthYear;
            this._height = height;
            this._grade = grade;
            this._faculty = faculty;
        }

        public Student(string name, string id, double iYear, int iheight, double igrade, string faculty)
        {
            this.name = name;
            this.id = id;
            this.iYear = iYear;
            this.iheight = iheight;
            this.igrade = igrade;
            this.faculty = faculty;
        }

        public string Name
        {
            get { return _name; }
        }
        public string ID
        {
            get { return _id; }
        }
        public int BirthYear
        {
            get { return _birthYear; }
        }
        public int Height
        {
            get { return _height; }
        }
        public double Grade
        {
            get { return _grade; }
        }
        public string Faculty
        {
            get { return _faculty; }
        }
        public int myAge()
        {
            int age = 2023 - _birthYear;
            return age;
        }
    }
}
