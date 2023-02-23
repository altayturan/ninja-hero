public class LevelTextUpdater : PowerUpTextUpdater
{
    protected override string GetText()
    {
        return "Lvl. " + powerUp.Level.ToString();
    }
}
