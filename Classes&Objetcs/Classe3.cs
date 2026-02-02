namespace C_course
{
    class Song
    {
        public string title;
        public string singer;
        public int duration;

        //static attribute
        public static int songcount = 0;

        public Song(string aTitle,string aSinger,int aDuration)
        {
            title = aTitle;
            singer = aSinger;
            duration = aDuration;
            songcount ++;
        }

        public void getsSongCount()
        {
            Console.WriteLine($"As of now there are {songcount} songs available");
        }
    }
}