using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;

        public Student(string name, string surname, string group, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            this.isGraduated = point >= 65;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Ad: {Name}, Soyad: {Surname}, Qrup: {Group}, Bal: {Point}");
        }
        public void CheckGraduation()
        {
            if ( isGraduated )
            {
                Console.WriteLine("Telebe mezun olub");
            }
            else
            {
                Console.WriteLine("Telebe mezun olmayib");
            }
        }
       public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("Diplomdan kesilib");
            }else if(Point >=65 &&  Point <= 80)
            {
                Console.WriteLine("Adi diplom ");
            }else if(Point >= 80 && Point <= 90 ){
                Console.WriteLine(" Seref diplomu");
            }else 
            {
                Console.WriteLine("Yuksek seref diplomu");
            }
        }
    }

}
