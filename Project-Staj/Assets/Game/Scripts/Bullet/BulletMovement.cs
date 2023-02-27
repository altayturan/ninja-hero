using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] private BulletData bulletData;
    [SerializeField] private StateData stateData;
    #endregion

    #region Monobehavior Functions


    private void Update()
    {
        if (stateData.CurrentState == States.PLAY)
        {
            transform.Translate(Vector3.forward * bulletData.Speed * Time.deltaTime);
        }
    }


    #endregion


}
