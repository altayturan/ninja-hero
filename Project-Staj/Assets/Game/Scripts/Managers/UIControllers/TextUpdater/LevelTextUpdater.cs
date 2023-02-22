public class LevelTextUpdater : BoosterTextUpdater
{
    protected override string GetText()
    {
        return "Lvl. " + powerUp.Level.ToString();
    }
}
