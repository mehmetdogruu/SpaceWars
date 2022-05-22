using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi : MonoBehaviour
{
    int maksHiz;
    string renk;
    public int Makshiz
    {
        get{ return maksHiz; }
    }

    public string Renk
    {
        get { return renk; }
    }

    public UzayGemisi(int maksHiz,string renk)
    {
        this.renk = renk;
        this.maksHiz = maksHiz;
    }
    public UzayGemisi(int maksHiz)
    {
        this.maksHiz = maksHiz;
    }
   //public void Hizlandirici()
   // {
   //     maksHiz += Random.Range(5, 20);
   //     Debug.Log(maksHiz);
   // }
    public void Yavaslaticici()
    {
        maksHiz -= Random.Range(5, 20);
        Debug.Log(maksHiz);
    }
}
