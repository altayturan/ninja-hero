public class SpeedyPooler : Pooler<SpeedyEnemy>
{
    public override void CreateNew()
    {
        base.CreateNew();
        temp.SpeedyPooler = this;
    }
}
