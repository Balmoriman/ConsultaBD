//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeDimension
    {
        public int ClaveDimension { get; set; }
        public System.DateTime Date { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
        public int Month_Number_Year { get; set; }
        public int Month_Number_Of_Quarter { get; set; }
        public int Week_Number_Of_Year { get; set; }
        public int Week_Number_Of_Quarter { get; set; }
        public int Week_Number_Of_Month { get; set; }
        public int Day_Number_Of_Year { get; set; }
        public int Day_Number_Of_Quarter { get; set; }
        public int Day_Number_Of_Month { get; set; }
        public int Day_Number_Of_Week { get; set; }
        public string Month_Name { get; set; }
        public string Day_Name { get; set; }
    }
}
