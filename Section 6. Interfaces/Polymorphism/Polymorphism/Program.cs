using System.Net.Mail;

namespace Polymorphism;

public class Program
{
    static void Main()
    {
        var encoder = new VideoEncoder();
        encoder.Encode(new Video());
    }
}