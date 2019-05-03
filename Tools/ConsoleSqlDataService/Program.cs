namespace ConsoleSqlDataService
{
    using System;
    using System.Linq;
    using DAL;
    using Models;

    public class Program
    {
        static void Main(string[] args)
        {
            /*URL: http://www.csharpdocs.com/how-to-create-sql-data-access-layer-in-c-using-ado-net-part-2/ */
            /* https://www.youtube.com/watch?v=DiYppDWrKDk */

            var userDal = new UserDal();

            var user = new User
            {
                FirstName = "First",
                LastName = "Last",
                Dob = DateTime.Now.AddDays(-3000),
                IsActive = true
            };

            //INSERT
            var lastId = userDal.Insert(user);
            Console.WriteLine("\nINSERTED ID: " + lastId);

            //DATATABLE
            var users = userDal.SelectAll();
            Console.WriteLine("\nTOTAL ROWS IN TABLE(DATATABLE): " + users.Count());

            //DATAREADER
            users = userDal.GetAll();
            Console.WriteLine("\nTOTAL ROWS IN TABLE(DATAREADER): " + users.Count());

            userDal = new UserDal();

            //SCALAR
            int scalar = userDal.GetScalarValue();
            Console.WriteLine("\nSCALAR VALUE: " + scalar.ToString());

            //UPDATE
            user = new User
            {
                Id = lastId,
                FirstName = "First1",
                LastName = "Last1",
                Dob = DateTime.Now.AddDays(-5000)
            };
            userDal.Update(user);

            var userDetails = userDal.GetById(user.Id);
            Console.WriteLine(string.Format("\nUPADTED VALUES FirstName{0}: LastName:{1}", userDetails.FirstName, userDetails.LastName));

            //DELETE
            userDal.Delete(user.Id);

            users = userDal.SelectAll();
            Console.WriteLine("\nTOTAL ROWS IN TABLE(DATATABLE): " + users.Count());

            Console.WriteLine("\n\nPress any key to exist...");
            Console.ReadKey();
        }
    }
}
