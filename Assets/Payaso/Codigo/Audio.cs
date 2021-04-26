using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource audioSource;

    public void EjecutarSonido(AudioClip[] listaDeSonidos)
    {
        int rand = Random.Range(0, listaDeSonidos.Length);
        AudioClip audio = listaDeSonidos[rand];
        audioSource.PlayOneShot(audio);
    }
}
