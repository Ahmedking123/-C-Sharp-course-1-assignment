namespace C_Sharp_1__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First question

            Book book = new Book();

            object obj = book;

            Console.WriteLine(obj);
            #endregion
            #region Second question

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            #endregion





        }
    }
}
