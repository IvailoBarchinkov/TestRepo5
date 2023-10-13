namespace GitTestRepository
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cookiesCnt = int.Parse(Console.ReadLine());
            List<string> cookies = new List<string>();
            for (int i = 0; i < cookiesCnt; i++)
            {
                string cookie = Console.ReadLine();
                cookies.Add(cookie);
            }       
            string cookieToDelete = Console.ReadLine();
            string cookieToAdd = Console.ReadLine();
            DeleteCookie(cookieToDelete);
            AddCookie(cookieToAdd);
            ListCookies();
            
        }
        static void DeleteCookie(string cookieName)
        {
            if(cookies.Contains(cookieName))
            {
                cookies.Remove(cookieName);
            }
            else
            {
             Console.WriteLine("There is no such cookie in the cookie box!");
            }
        }
        static void AddCookie(string cookieName)
        {
            if(!cookies.Contains(cookieName))
            {
                cookies.Add(cookieName);
            }
            else
            {
                COnsole.WriteLine("This cookie already exists in the cookie box!");
            }
        }
        static void ListCookies()
        {
            Console.WriteLine(string.Join(", ", cookies));
        }
    }
}