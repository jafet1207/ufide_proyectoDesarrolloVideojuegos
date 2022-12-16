using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinController : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 1;

    [SerializeField]
    AudioSource audioCoin;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collectibleController.addCoin();
        audioCoin.Play();
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
