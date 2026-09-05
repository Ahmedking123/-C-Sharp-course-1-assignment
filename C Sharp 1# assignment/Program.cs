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

            #region Third question
            // compile time error

            int Pages = 464;
            #endregion
            #region Fourth question
             
            try
            {
                int DivideByZero = 10;
                Console.WriteLine(DivideByZero / 0);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
            #region Fifth question
            int pages = 300;
            double db = pages;
            #endregion
            #region Sixth question
            double price = 49.99;
            int priceInt = (int)price;
            #endregion
            #region Seventh question
            string pagesText = "464";
            int pagesTextInt = Convert.ToInt32(pagesText);
            #endregion






        }
    }
}
