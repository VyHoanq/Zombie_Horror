using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoots : MonoBehaviour
{
    public PlayerScript player;
    private float healthToGive = 120f;
    private float radius = 2.5f;

    public AudioClip HealthBoostSound;
    public AudioSource audioSource;

    public Animator openBoxHealth;

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < radius)
        {

            if (Input.GetKeyDown("f"))
            {
                openBoxHealth.SetBool("Open", true);
                player.presentHealth = healthToGive;

                //sound effect
                audioSource.PlayOneShot(HealthBoostSound);
                Object.Destroy(gameObject, 1.5f);
            }

        }
    }

}
