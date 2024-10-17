namespace IndexOutOfBoundException
{
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };
               
                foreach(var i in arr)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(arr[5]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
