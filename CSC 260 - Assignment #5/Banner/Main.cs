using System;
using System.Collections.Generic;
using System.Text;

namespace CSC_260_Assignment_4
{
	class Main
	{
		public Main()
		{
			Advisor.BrowseCourses(221, Advisor, 001);
			Student.BrowseCourses(001, Student);
			Faculty.BrouseCourses(111, Faculty);

			return;
		}
	}
}