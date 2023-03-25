using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210028
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // Prekondisi 1 : Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null.
            Debug.Assert(title != null && title.Length <= 100, "Title null atau lebih dari 100 karakter");
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            // Input penambahan play count maksimal 10.000.000 per panggilan method-nya
            Debug.Assert(playCount <= 10000000, "Input penambahan play count maksimal 10.000.000 per panggilan method-nya.");

            // Exception : pastikan jumlah penambahan play count tidak melebihi batas tertinggi integer (overflow).
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (OverflowException err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID\t\t: " + this.id);
            Console.WriteLine("Judul video\t: " + this.title);
            Console.WriteLine("Play count\t: " + this.playCount);
        }
    }
}
