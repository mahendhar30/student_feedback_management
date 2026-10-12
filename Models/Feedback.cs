using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace student_feedback_management.Models
{
    public class Feedback
    {
        public string EnrolmentNo { get; set; }

        public string StudentName { get; set; }

        public string Subject { get; set; }

        public int Rating { get; set; }

        public string Comments { get; set; }
    }
}
