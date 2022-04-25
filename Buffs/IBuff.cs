namespace DungeonGame.Buffs
{
    public interface IBuff
    {
        int BuffID { get; }
        int Duration { get; }

        void InEffect();

        string ToString();
    }
}