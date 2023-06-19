namespace ClassRace
{
    public class Races
    {
        int raceId;
        public int RaceId { get => raceId; set => raceId = value; }
        string race;
        public string Race { get => race; set => race = value; }


        public Races(int _raceId, string _race)
        {
            raceId = _raceId;            
            race = _race;
        }

    }
}