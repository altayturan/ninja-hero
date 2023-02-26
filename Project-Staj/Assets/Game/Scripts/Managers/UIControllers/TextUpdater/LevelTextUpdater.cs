public class LevelTextUpdater : BoosterTextUpdater
{
    
    protected override string GetText()
    {
        return "Lvl. " + booster.Level.ToString();
    }
}
