using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip gameOver;
    [SerializeField]
    AudioClip ates;
    [SerializeField]
    AudioClip asteroidPatlama;
    AudioSource auidoSource;
    void Start()
    {
        auidoSource = GetComponent<AudioSource>();
    }

    public void AsteroidPatlama()
    {
        auidoSource.PlayOneShot(asteroidPatlama);
    }
    public void GameOver()
    {
        auidoSource.PlayOneShot(gameOver);
    }
    public void Ates()
    {
        auidoSource.PlayOneShot(ates,0.4f);
    }
}
