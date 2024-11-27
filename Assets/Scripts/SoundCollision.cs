using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollision : MonoBehaviour
{
    public AudioSource BonusMario;

    public AudioClip colision;


    private void OnTriggerEnter(Collider other)
    {
        BonusMario.PlayOneShot(colision);
    }
}
