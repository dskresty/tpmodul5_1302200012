using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5_1302200012
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            id = random.Next(0, 100000);
            PlayCount = 0;
        }

        public void IncreasePlayCount(int playC)
        {
            PlayCount = playC + PlayCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("judul: " + title);
            Console.WriteLine("play count: " + PlayCount);
        }

    }
}
