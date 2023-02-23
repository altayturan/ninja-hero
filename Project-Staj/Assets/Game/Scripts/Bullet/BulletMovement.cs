using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] private BulletData bulletData;
    #endregion

    #region Monobehavior Functions


    private void Update()
    {
        transform.Translate(Vector3.forward * bulletData.Speed * Time.deltaTime);
    }
    #endregion


}
