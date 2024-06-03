using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSoundStep : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] public AudioClip[] footstepSound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private AudioClip GetRandomFootstep()
    {
        return footstepSound[UnityEngine.Random.Range(0, footstepSound.Length)];
    }
    private void Step()
    {
        AudioClip clip = GetRandomFootstep();
        audioSource.PlayOneShot(clip);
    }
}
