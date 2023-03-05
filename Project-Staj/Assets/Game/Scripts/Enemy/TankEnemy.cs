public class TankEnemy : BaseEnemy
{
    private TankPooler tankPooler;

    public TankPooler TankPooler { get => tankPooler; set => tankPooler = value; }

    public override void DestroyEnemy()
    {
        TankPooler.PutToPool(this);
    }
}
