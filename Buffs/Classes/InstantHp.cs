namespace DungeonGame.Buffs.Classes;

internal class InstantHp : IBuff
{
    private readonly int _buffID = 0;
    public int BuffID { get => _buffID; }
    private int _duration = 1;
    public int Duration { get => _duration; }

    public void InEffect()
    {
        _duration--;
    }
}