﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
	using System.Data;

	public partial class Exam
    {
        public string ExamID { get; set; }
		public string SubjectID { get; set; }
		public string TestFormID { get; set; }
		public byte? PercentMark { get; set; }
		public string ExamRole { get; set; }
		public byte ExamTime { get; set; }
		public int QCount { get; set; }
        public int QCurrentCount { get; set; }
		public byte QuizTimes { get; set; }
		public bool Status { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

		public Exam()
		{

		}

		public Exam(DataRow row)
		{
			ExamID = row["ExamID"].ToString();
			SubjectID = row["SubjectID"].ToString();
			TestFormID = row["TestFormID"].ToString();
			byte.TryParse(row["PercentMark"].ToString(), out byte percent);
			PercentMark = percent;
			ExamTime = byte.Parse(row["ExamTime"].ToString());
			QCount = int.Parse(row["QCount"].ToString());
			QCurrentCount = int.Parse(row["QCurrentCount"].ToString());
			QuizTimes = byte.Parse(row["QuizTimes"].ToString());
			Status = bool.Parse(row["Status"].ToString());
		}
	}
}