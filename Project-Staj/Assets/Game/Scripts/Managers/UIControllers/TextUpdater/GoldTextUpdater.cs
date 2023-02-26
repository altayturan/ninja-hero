public class GoldTextUpdater : BoosterTextUpdater
{

    protected override string GetText()
    {
        return booster.Cost.ToString();
    }
}
