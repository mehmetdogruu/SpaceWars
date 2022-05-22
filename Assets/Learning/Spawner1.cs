using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    Sayac geriSayimsayacii;
    // Start is called before the first frame update
    void Start()
    {
        geriSayimsayacii = gameObject.AddComponent<Sayac>();
        geriSayimsayacii.Toplamsure = 1;
        geriSayimsayacii.Calistir();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimsayacii.Bitti)
        {
            SpawnAsteroid();
            geriSayimsayacii.Calistir();
        }
        
    }
    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
