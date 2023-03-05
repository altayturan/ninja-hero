public class SpeedyEnemy : BaseEnemy
{
    private SpeedyPooler speedyPooler;
    public SpeedyPooler SpeedyPooler { get => speedyPooler; set => speedyPooler = value; }
    public override void DestroyEnemy()
    {
        speedyPooler.PutToPool(this);
    }      
}
