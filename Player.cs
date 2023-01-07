using System;


namespace MunchkinCounter
{
    public class Player
    {
        public string name;
        public string gender;
        public int level;
        public int gear;


        
    }

    public class Create 
    {
        public Player CreatePlayer(string name, string gender, int level, int gear) {

          Player newPlayer = new Player();
          newPlayer.name = name;
          newPlayer.gender = gender;
          newPlayer.level = level;
          newPlayer.gear = gear;
          return newPlayer;
    }

    }

    
}


