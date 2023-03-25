namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ICallable callable = null;
            IBrowsable browsable = new Smartphone();
            foreach(string phoneNo in phoneNumbers)
            {
                try
                {
                    if(phoneNo.Length == 7)
                    {
                        callable = new StationaryPhone();
                        
                    }
                    else
                    {
                        callable = new Smartphone();
                       
                    }
                    Console.WriteLine(callable.Call(phoneNo));
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach(string url in urls)
            {
                try
                {
                    Console.WriteLine(browsable.Browse(url));
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}