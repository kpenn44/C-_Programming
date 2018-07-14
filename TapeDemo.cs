using System;

namespace TapeDemo
{
    class TapeDemo
    {
        static void Main(string[] args)
        {
         AdhesiveTape tape1 = new AdhesiveTape();
         VideoTape tape2 = new VideoTape();
         Tape tape3 = new tape();

            tape1.stick = 6;
            tape1.length = 7;
            tape1.width = 4;
            Console.WriteLine("Tape 1 stick is {0}", tape1.stick);

            tape2.PlayingTime = 95;
            tape2.length = 5;
            tape2.width = 2;

            Console.WriteLine("Tape 2 length is {0} minutes long", tape2.PlayingTime);

            tape3.length = 12;
            tape3.width = 10;

            Console.WriteLine("Tape 3 is {0} feet long", tape3.Length);

       
        }
    }
    class Tape
    {
        private int length;
        private int width;

        public int Length
        {
            get { return length;}
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public override string ToString()
        {
            return (GetType() + "" + length + "" + width);
        }
    }
    class AdhesiveTape : Tape

        public int Stick
        {
        get { return stick; }
        set { if ((value >= 1) && (value <= 10)) ; }

    }
        stick = value; 
        }
           else
           {
              Console.WriteLine("WRONG NUMBER FOR STICKINESS FACTOR");
   }        

  class VideoTape : Tape
{
    int playingTime;

    public int PlayingTime
    {
        get { return playingTime; }
        set { playingTime = value; }
    }
}

}

