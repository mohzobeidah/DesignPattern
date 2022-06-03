namespace ProxyPattern
{
    public class Subject : ISubject
    {
        public void Request()
        {
         Console.WriteLine("Request take it to the real subject");
        }
    }
}