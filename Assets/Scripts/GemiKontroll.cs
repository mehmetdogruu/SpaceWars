using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontroll : MonoBehaviour
{
    [SerializeField]
    GameObject kursunPrefab;
    [SerializeField]
    GameObject patlamaPrefab;
    OyunControl oyunControl;
    
    void Start()
    {
        oyunControl = Camera.main.GetComponent<OyunControl>();
    }

    
    const float hareketGucu = 10;

    void Update()
    {
        Vector3 position = transform.position;
        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");
        if (Input.GetAxis("Horizontal") != 0)

        {
            position.x += yatayInput * hareketGucu * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") != 0)

        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }
        transform.position = position;
        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
            Vector3 kursunPozisyon = gameObject.transform.position;
            kursunPozisyon.y += 1;
            Instantiate(kursunPrefab, kursunPozisyon, Quaternion.identity);
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().GameOver();
            oyunControl.OyunuBitir();
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

}
