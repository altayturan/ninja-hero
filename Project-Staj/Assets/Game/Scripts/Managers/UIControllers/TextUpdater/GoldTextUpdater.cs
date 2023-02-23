public class GoldTextUpdater : PowerUpTextUpdater
{

    protected override string GetText()
    {
        return powerUp.Cost.ToString();
    }
}
