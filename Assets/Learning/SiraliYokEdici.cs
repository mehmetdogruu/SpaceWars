﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiraliYokEdici : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    GameObject uzayGemisi;
    List<GameObject> asteroidList;
    GameObject hedefAsteroid;
    void Start()
    {
        uzayGemisi = GameObject.FindGameObjectWithTag("Player");
        asteroidList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            GameObject asteroid = Instantiate(asteroidPrefab, position, Quaternion.identity);
            asteroidList.Add(asteroid);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            HedefiYokEt();
        }
    }
    GameObject EnYakinAsteroid()
    {
        GameObject enYakinAsteroid;
        float enYakinMesafe;
        if (asteroidList.Count==0)
        {
            return null;
        }
        else
        {
            enYakinAsteroid = asteroidList[0];
            enYakinMesafe = MesafeOlcer(enYakinAsteroid);

        }
        foreach(GameObject asteroid in asteroidList)
        {
            float mesafe = MesafeOlcer(asteroid);
                if (mesafe<enYakinMesafe)
            {
                enYakinMesafe = mesafe;
                enYakinAsteroid = asteroid;
            }
        }
        return enYakinAsteroid;
    }

    public void HedefiYokEt()
    {
        hedefAsteroid = EnYakinAsteroid();
        if (hedefAsteroid != null)
        {
            hedefAsteroid.GetComponent<Destroyer>().AsteroidYokEdici(1);
            asteroidList.Remove(hedefAsteroid);
        }
    }

    float MesafeOlcer(GameObject hedef)
    {
        return Vector3.Distance(uzayGemisi.transform.position, hedef.transform.position);
    }



}