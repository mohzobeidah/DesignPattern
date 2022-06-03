public sealed class LazyLoadingClassGenrator
{
    private static volatile Lazy<LazyLoadingClassGenrator?> instance = new Lazy<LazyLoadingClassGenrator?> (()=>new LazyLoadingClassGenrator());
     public Guid GUid { get; }
    public LazyLoadingClassGenrator()
    {
        this.GUid =  Guid.NewGuid();
        
    }
    public static LazyLoadingClassGenrator? Instance=>instance.Value;


    public override string ToString()
    {
        return GUid.ToString();
    }
}