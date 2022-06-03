namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        private Subject _realSubject;

        public Proxy(Subject realSubject)
        {
            _realSubject = realSubject;
        }



        public void Request()
        {
            if (checkAccess() )
            {
                _realSubject = new Subject();
                _realSubject.Request();
                LogAccess();    
            }
           
        }
        public bool checkAccess()
        {
            Console.WriteLine("Checking access");
            return true;
        }


        public void LogAccess()
        {
            Console.WriteLine("Logging access");
         
        }
    }
}