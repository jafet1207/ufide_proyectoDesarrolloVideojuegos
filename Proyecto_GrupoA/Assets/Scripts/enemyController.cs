using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * (moveSpeed * 10), Space.World);
    }

    public void stopEnemy(float playerZ)
    {
        /*while (this.gameObject.transform.position.z < playerZ)
        {
            Debug.Log("Corriendo");
        }*/
        moveSpeed = 0;
    }
}
