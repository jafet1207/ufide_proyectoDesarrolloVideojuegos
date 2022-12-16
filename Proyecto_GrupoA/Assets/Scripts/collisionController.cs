using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
    private playerController player;
    private Animator animator;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            //Console.WriteLine("Colisión");
            //Debug.Log("Colisión");

            player = gameObject.GetComponentInParent<playerController>();
            player.stopPlayer();
            animator = gameObject.GetComponentInParent<Animator>();
            animator.SetTrigger("Die");

        }

        if (collision.collider.CompareTag("Collectible"))
        {
            //Console.WriteLine("Colisión");
            //Debug.Log("Colisión");

            //player = gameObject.GetComponentInParent<playerController>();
            //player.stopPlayer();
        }
    }
}
