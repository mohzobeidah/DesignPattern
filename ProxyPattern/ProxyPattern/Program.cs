// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Console.WriteLine("Hello, World!");


var proxy = new Proxy(new Subject());
proxy.Request();