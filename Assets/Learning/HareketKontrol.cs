using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    float colliderBoyYarim;
    float colliderEnYarim;
    void Start()
    {
        //Oyun objesini rastgele bir kuvvetle hareket ettirir
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-5, 5),Random.Range(-5,5)),ForceMode2D.Impulse);
      
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        colliderBoyYarim = collider.size.y / 2;
        colliderEnYarim=collider.size.x / 2;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Sıkı Tutun");
    }

    // Update is called once per frame
    void Update()
    {
        //ASTEROİD MOUSE U TAKİP ETSİN
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);
        //transform.position = position;
        //Ekrandakal();
    }
    void Ekrandakal()
    {
        Vector3 position = transform.position;
        if(position.x-colliderEnYarim<EkranHesaplayıcı.Sol)
        {
            position.x = EkranHesaplayıcı.Sol + colliderEnYarim;
        }else if(position.x+colliderEnYarim>EkranHesaplayıcı.Sag)
        {
            position.x = EkranHesaplayıcı.Sag - colliderEnYarim;
        }
        if(position.y+colliderBoyYarim>EkranHesaplayıcı.Ust)
        {
            position.y = EkranHesaplayıcı.Ust - colliderBoyYarim;
        }else if(position.y-colliderBoyYarim<EkranHesaplayıcı.Alt)
        {
            position.y = EkranHesaplayıcı.Alt + colliderBoyYarim;
        }
        transform.position = position;
    }
}
