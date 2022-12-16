using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 3;

    [SerializeField]
    float leftRightSpeed = 4;

    [SerializeField]
    float leftBorder = -2;

    [SerializeField]
    float rightBorder = 2;

    [SerializeField]
    enemyController enemy;

    [SerializeField]
    GameObject results;

    [SerializeField]
    GameObject pauseButton;

    [SerializeField]
    float endDistance;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * (moveSpeed*10), Space.World);

        //Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftBorder)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (leftRightSpeed * 10));
            }
        }

        //Right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightBorder)
            {
                transform.Translate(Vector3.right * Time.deltaTime * (leftRightSpeed * 10));
            }
        }

        //End
        if (this.gameObject.transform.position.z >= endDistance)
        {
            pauseButton.SetActive(false);
            Time.timeScale = 0f;
            results.SetActive(true);
        }
    }

    public void stopPlayer()
    {
        moveSpeed = leftRightSpeed = 0;
        enemy.stopEnemy(this.gameObject.transform.position.z);
    }
}
