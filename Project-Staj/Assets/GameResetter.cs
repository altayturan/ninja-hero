using UnityEngine;

public class GameResetter : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private BulletData shuriken;
    [SerializeField] private EnemyData speedy;
    [SerializeField] private EnemyData tank;
    [SerializeField] private Stat spawnInterval;
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;
    [SerializeField] private Resource time;
    [SerializeField] private Resource gold;
    [SerializeField] private PowerUp attackSpeed;
    [SerializeField] private PowerUp damage;
    [SerializeField] private PowerUp numberOfShot;
    [SerializeField] private Skill diagonal;
    [SerializeField] private Skill damageAll;
    [SerializeField] private Skill highAttackSpeed;
    [SerializeField] private StateData stateData;

    private void Start()
    {
        ResetAll();
    }
    public void ResetAll()
    {
        playerData.ResetPlayer();
        shuriken.ResetBullet();
        speedy.RestartEnemy();
        tank.RestartEnemy();
        spawnInterval.ResetStats();
        enemyHealthMultiplier.ResetStats();
        spawnIntervalMultiplier.ResetStats();
        time.ResetResources();
        gold.ResetResources();
        attackSpeed.ResetPowerUp();
        damage.ResetPowerUp();
        numberOfShot.ResetPowerUp();
        diagonal.ResetSkill();
        damageAll.ResetSkill();
        highAttackSpeed.ResetSkill();
        stateData.CurrentState = States.PLAY;
    }

}
