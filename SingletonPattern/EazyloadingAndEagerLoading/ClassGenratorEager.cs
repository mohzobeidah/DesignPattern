public sealed class ClassGenratorEager
{
    private static volatile ClassGenratorEager? instance = new ClassGenratorEager();
     public Guid GUid { get; }
    public ClassGenratorEager()
    {
        this.GUid =  Guid.NewGuid();
        
    }
    public static ClassGenratorEager? Instance=>instance;


    public override string ToString()
    {
        return GUid.ToString();
    }
}