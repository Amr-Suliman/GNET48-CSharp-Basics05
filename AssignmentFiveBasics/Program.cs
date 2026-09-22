namespace AssignmentFiveBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Question 1

            // private members are accessible only inside the class where they are declared.
            // So, password cannot be accessed from Main because Main is outside the Book class.

            // Book book = new Book();
            // Console.WriteLine(book.password); // Error: 'password' is inaccessible due to its protection level

            #endregion

        }
    }
}
