using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    const float hareketGucu = 10;
    bool topluyor = false;
    GameObject hedef;
    Rigidbody2D myrigidbody2D;
    Toplayici toplayici;
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<Toplayici>();

    }
    void GitveTopla()
    {
        hedef = toplayici.HedefYildiz;
        if (hedef != null)
        {
            Vector2 gidilecekyer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekyer.Normalize();
            myrigidbody2D.AddForce(gidilecekyer * hareketGucu, ForceMode2D.Impulse);
        }
    }
    void OnMouseDown()
    {
        if (!topluyor)
        {
            GitveTopla();
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == hedef)
        {
            toplayici.YildizYokEt(hedef);
            myrigidbody2D.velocity = Vector2.zero;
            GitveTopla();
        }

    }


    void Update()
    {

        //Vector3 position = transform.position;
        //float yatayInput = Input.GetAxis("Horizontal");
        //float dikeyInput = Input.GetAxis("Vertical");
        //if (Input.GetAxis("Horizontal") != 0)

        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime;
        //}
        //if (Input.GetAxis("Vertical") != 0)

        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}
        //transform.position = position;
    }

}