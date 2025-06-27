using System;

namespace BlazorTutorial1.Models
{
    [Serializable]
    public class User
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //Boolean tracking if name should be italisized
        public bool isItal { get; set; }
        //Boolean tracking if name should be bolded
        public bool isBold { get; set; }
        //Boolean tracking if name should be underlined
        public bool isUnln { get; set; }
        //Boolean tracking if name should be striked through
        public bool isStrk { get; set; } 
    }
}