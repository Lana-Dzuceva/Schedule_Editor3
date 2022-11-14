using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SheduleEditorV2
{
    public class ListGroups
    {
        public List<Group> groups;

        public List<Group> Groups
        {
            get;
            set;
        }
        public ListGroups()
        {
            groups = new List<Group>();
        }
    }

    public class Group
    {
        public List<AcademicClass> classes; // ScheduleAcademicClass

        public Group()
        {
            classes = new List<AcademicClass>();
        }
    }
    public enum ClassType
    {
        Lecture,
        Practice
    }
    public enum SubGroup
    {
        first,
        second
    }
    public class AcademicClass
    {
        public string classTitle;
        public Teacher teacher;
        public int hours;
        public ClassType type;
        public SubGroup subGroup;

        public AcademicClass() { }
        public AcademicClass(string classTitle, Teacher teacher, int hours, ClassType type, SubGroup subGroup)
        { 
            this.classTitle = classTitle;   
            this.teacher = teacher;
            this.hours = hours;
            this.type = type;
            this.subGroup = subGroup;

        }

        public SubGroup SubGroup
        {
            get => default;
            set
            {
            }
        }

        public ClassType ClassType
        {
            get => default;
            set
            {
            }
        }

        public Teacher Teacher
        {
            get => default;
            set
            {
            }
        }
    }

    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public class ScheduleAcademicClass : AcademicClass
    {
        int Audience;
        WeekDay weekDay;
        int ClassNumber;

        public ScheduleAcademicClass() : base()
        {

        }

        public WeekDay WeekDay
        {
            get => default;
            set
            {
            }
        }
    }
    public class Teacher
    {
        public string name;

        public Teacher(string name)
        {
            this.name = name;
        }
    }

}

