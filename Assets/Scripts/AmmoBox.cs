using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public Rifle rifle;
    private float magToGive = 120f;
    private float radius = 2.5f;

    public AudioClip AmmoBoostSound;
    public AudioClip audioSource;

    public Animator openBoxAmmo;

    private void Update()
    {
        if (Vector3.Distance(transform.position, rifle.transform.position) < radius)
        {

            if (Input.GetKeyDown("f"))
            {
                openBoxAmmo.SetBool("Open", true);
                //rifle.mag = magToGive;

                //sound effect
                //audioSource.PlayOneShot(AmmoBoostSound);
                Object.Destroy(gameObject, 1.5f);
            }

        }
    }
}
