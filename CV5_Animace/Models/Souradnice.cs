namespace CV5_Animace.Models
{
    public class Souradnice
    {
        public Souradnice(int pozX, int pozY, int imageSize) 
        {
            PozX = pozX;
            PozY = pozY;
            ImageSize = imageSize;
        }

        public int PozX { get; private set; }           //nebo jen { get; }
        public int PozY { get; private set; }           //nebo jen { get; }
        public int ImageSize { get; private set; }      //nebo jen { get; }

        public string Style => $"left: {PozX}px, top: {PozY}px;";

    }
}
