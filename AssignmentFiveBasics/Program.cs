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

            #region Question 2

            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);

            // internal members are accessible within the same project (assembly).
            // Since Book and Program are in the same project,
            // copiesInStock can be accessed from Main.

            // Output:
            // 5

            #endregion

            #region Question 3

            //Book book = new Book();

            //book.TItle = "C# Programming";

            //Console.WriteLine(book.TItle);

            #endregion
        }
    }
}
