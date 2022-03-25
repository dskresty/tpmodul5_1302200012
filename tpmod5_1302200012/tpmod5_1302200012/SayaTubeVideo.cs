using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title.Length < 100 && title != null, "Length nama jangan lebih dari 100 dan jangan juga NULL!");

            this.title = title;
            Random random = new Random();
            id = random.Next(0, 100000);
            PlayCount = 0;
        }

        public void IncreasePlayCount(int playC)
        {


            try
            {
                if (playC > 10000000) throw new Exception("playCount maksimal 10.000.000!");
                PlayCount = playC + PlayCount;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            
            Console.WriteLine("id: " + id);
            Console.WriteLine("judul: " + title);
            Console.WriteLine("play count: " + PlayCount);
        }

    }
}
