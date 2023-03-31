using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public AudioSource Music1;
    bool musicPlaying = true;
    private float MusicVolume = 1f;
    private void Start()
    {
        Music1 = GetComponent<AudioSource>();
    }
    public void Rta()
    {
        if (musicPlaying)
        {
            musicPlaying = !musicPlaying;
            Sond_minus();
        }
        else
        {
            musicPlaying = !musicPlaying;
            Sond_plus();
        }
    }
    float i;
    private void Sond_plus()
    {
        for (i=0; i!=1; i-=0.01f) 
        {
            Music1.volume = i;
            StartCoroutine(delay());
        }
    }
    private void Sond_minus()
    {
        for (i = 1; i != 0; i-=0.01f)
        {
            Music1.volume = i;
            StartCoroutine(delay());
        }
    }
    private IEnumerator delay()
    {
        yield return new WaitForSeconds(0.02f);
    }
}
