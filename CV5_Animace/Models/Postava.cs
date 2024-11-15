﻿namespace CV5_Animace.Models
{
    public class Postava
    {
        public Postava(string iDPostava, string jmeno, string image, int width) 
        {
            Jmeno = jmeno;
            IDPostava = iDPostava;
            Image = image;
            Width = width;
            AktualniPozice = 0;
        }
        public List<Souradnice> PoziceList {  get; private set; } = new List<Souradnice>(); 
        public string Jmeno { get; private set; }
        public string IDPostava { get; private set; }
        public string Image {  get; private set; }
        public int Width { get; private set; }
        public int AktualniPozice { get; private set; }
        public string Style {
            get
            {
                var poz = PoziceList[AktualniPozice];
                return poz.Style;
            }
        }
        public void PridejPozici(int pozX, int pozY, int imageSize)
        {
            var souradnice = new Souradnice(pozX, pozY, imageSize);
            PoziceList.Add(souradnice);
        }
    }
}
