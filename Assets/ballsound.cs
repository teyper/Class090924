using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsound : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
   


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (audioSource != null)
        {
            audioSource.Play();
        }

    }
}