namespace ConsoleProviderDataService.Models
{
    using System;

    public class User
    {
        #region Properties

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public bool IsActive { get; set; }

        #endregion
    }
}
