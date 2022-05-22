using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    [SerializeField]
    GameObject yildizPrefab;
    List<GameObject> yildizlar = new List<GameObject>();

    /// <summary>
    /// Hedefteki yıldızları söyler
    /// </summary>
    public GameObject HedefYildiz
    {
        get
        {
            if (yildizlar.Count > 0)
            {
                return yildizlar[0];
            }
            else
            {
                return null;
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            Vector3 oyunDunyasiPozisyon = Camera.main.ScreenToWorldPoint(position);
            yildizlar.Add(Instantiate(yildizPrefab, oyunDunyasiPozisyon, Quaternion.identity));
        }
    }
    /// <summary>
    /// Parametre olarak gönderilen yıldızı yok eder
    /// </summary>
    /// <param name="YokEdilecekYildiz"></param>
    public void YildizYokEt(GameObject YokEdilecekYildiz)
    {
        yildizlar.Remove(YokEdilecekYildiz);
        Destroy(YokEdilecekYildiz);
    }
}
