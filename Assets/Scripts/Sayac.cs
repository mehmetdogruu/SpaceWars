using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac : MonoBehaviour
{
    float toplamsure = 0;
    float gecensure = 0;
    bool calisiyor = false;
    bool basladi = false;
    public float Toplamsure
    {
        set
        {
            if(!calisiyor==true)
            {
                toplamsure = value;
            }
        }
        
    }
    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor;
        }
    }
    public void Calistir()
    {
        if(toplamsure>0)
        {
            calisiyor = true;
            basladi = true;
            gecensure = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (calisiyor)
        {
            gecensure += Time.deltaTime;
            if (gecensure >= toplamsure)
            {
                calisiyor = false;
            }
        }
    }
}
