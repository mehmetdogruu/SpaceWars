using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursun : MonoBehaviour
{
    Sayac geriSayimSayaci;
    [SerializeField]
    GameObject kursunPrefab;
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 18),ForceMode2D.Impulse);
        geriSayimSayaci = gameObject.AddComponent<Sayac>();
        geriSayimSayaci.Toplamsure = 3;
        geriSayimSayaci.Calistir();
    }
    

    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }

}
