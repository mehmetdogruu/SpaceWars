using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaSayaci : MonoBehaviour
{
    Sayac gerisayim;
   
    void Start()
    {
        gerisayim = gameObject.AddComponent<Sayac>();
        gerisayim.Toplamsure = 1;
        gerisayim.Calistir();
        
    }

    void Update()
    {
        if (gerisayim.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
