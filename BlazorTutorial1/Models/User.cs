using System;

namespace BlazorTutorial1.Models
{
    [Serializable]
    public class User
    {
        public required Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        // TODO Rework this so it's a dictionary of options or something more dynamic
        //      so you can build the settings table better in UserEdit.razor

        //Boolean tracking if name should be italisized
        public required bool IsItal { get; set; }
        //Boolean tracking if name should be bolded
        public required bool IsBold { get; set; }
        //Boolean tracking if name should be underlined
        public required bool IsUnln { get; set; }
        //Boolean tracking if name should be striked through
        public required bool IsStrk { get; set; }
        public string DecoratedName()
        {
            string returnName = this.FirstName + " " + this.LastName;
            if (IsItal)
            {
                returnName = "<i>" + returnName + "</i>";
            }
            if (IsBold)
            {
                returnName = "<b>" + returnName + "</b>";
            }
            if (IsUnln)
            {
                returnName = "<u>" + returnName + "</u>";
            }
            if (IsStrk)
            {
                returnName = "<del>" + returnName + "</del>";
            }
            return returnName;
        }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}