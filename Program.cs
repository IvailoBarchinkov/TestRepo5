﻿namespace GitTestRepository
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
            
            //create method that adds a given cookie to the list if is doesnt exist 
            //create method that gives all the cookies from the list
            
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
    }
}