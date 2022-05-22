using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject explodePrefab;
    Sayac sayacim;
    void Start()
    {
        sayacim = gameObject.AddComponent<Sayac>();
    }

    void Update()
    {
        if (sayacim.Bitti)
        {
            Instantiate(explodePrefab,gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
           
            
        }
    }
    public void AsteroidYokEdici(int sure)
    {
        sayacim.Toplamsure = sure;
        sayacim.Calistir();
    }
}
