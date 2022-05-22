using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UzayGemisi gemi1 = new UzayGemisi(Random.Range(80,100));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(80,100), "Gri");
        gemi1.Yavaslaticici();
        gemi2.Yavaslaticici();

        if (gemi1.Makshiz > gemi2.Makshiz)
        {
            Debug.Log("Kazanan Gemi1");
        }
        else if (gemi2.Makshiz > gemi1.Makshiz)
        {
            Debug.Log("Kazanan Gemi2");
        }
        else 
        {
            Debug.Log("Berabere");
        }

        //int yokEdilenAsteroid=25;
        //int playerhp=100;
        //if(yokEdilenAsteroid>=20 || playerhp>=80)
        //{
        //    Debug.Log("Perfect");
        //}
       //switch(yokEdilenAsteroid)
       // {
       //     case 1:Debug.Log("Güzel Başlangıç");break;
       //     case 10:Debug.Log("İyisin Ha");break;
       //     default:Debug.Log("Kötü");break;
       // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
