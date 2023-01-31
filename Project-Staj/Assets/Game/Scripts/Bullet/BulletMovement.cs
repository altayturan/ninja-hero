using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Variables
    private float speed;

    #endregion

    #region Monobehavior Functions
    private void Update()
    {
        speed = StatisticManager.Instance.bulletSpeed;
        transform.Translate(Time.deltaTime * Vector3.forward * speed);
    }
    #endregion


}
