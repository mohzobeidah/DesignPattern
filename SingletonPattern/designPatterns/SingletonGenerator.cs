
public  sealed  class SingletonGenerator
{
    private static volatile SingletonGenerator instance=null;
    private static object syncRootObject = new object();
    private Guid Guid; 
    public static SingletonGenerator GetInstance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRootObject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonGenerator();
                        instance.Guid =  Guid.NewGuid();
                    }
                }
            }
            return instance;
        }
    }


    public override string ToString()
    {
        return Guid.ToString();
    }

// Add
}

