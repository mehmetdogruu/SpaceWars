using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{
    Sayac gerisayimsayaci;
    float baslangıcZamanı;
    // Start is called before the first frame update
    void Start()
    {
        gerisayimsayaci = gameObject.AddComponent<Sayac>();
        gerisayimsayaci.Toplamsure = 1;
        gerisayimsayaci.Calistir();
        baslangıcZamanı = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(gerisayimsayaci.Bitti)
        {
            float gecensure = Time.time - baslangıcZamanı;
            Debug.Log(gecensure);
            baslangıcZamanı = Time.time;
            gerisayimsayaci.Calistir();
        }
    }
}
