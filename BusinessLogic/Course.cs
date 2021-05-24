using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string _courseName;
        private string _instructorName;
        private byte _numberOfCredit;

        public Course(string courseName)
        {
            InstructorName = "STAFF";
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName 
        {
            get 
            {
                return _instructorName;
            }
            set
            {
                _instructorName = value;
            }
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get
            {
                return _courseName;
            }
            set
            {
                if(value == null)
                {
                    
                    throw new ArgumentNullException();
                }
                else
                {
                    _courseName = value;
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get
            {
                return _numberOfCredit;
            }
            set
            {
                if (value < 30 && value > 0)
                {
                    _numberOfCredit = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
