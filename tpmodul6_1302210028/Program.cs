// See https://aka.ms/new-console-template for more information


using tpmodul6_1302210028;

internal class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Rihan Hidayat");

        for (int i = 0; i < 1000; i++)
        {
            video.IncreasePlayCount(10000000);
        }
        
        video.PrintVideoDetails();
    }
}