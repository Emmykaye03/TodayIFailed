//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TIF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Failure
    {
        public static void Main()
        {
            DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
            Console.WriteLine(date1.ToString());

            // Get date-only portion of date, without its time.
            DateTime dateOnly = date1.Date;
        }
        public int FailID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
