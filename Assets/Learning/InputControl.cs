using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    List<GameObject> asteroidList = new List<GameObject>();
   
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log(Input.mousePosition);
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            for (int i = 0; i < 20; i++)
            {
                asteroidList.Add(Instantiate(asteroidPrefab, position, Quaternion.identity));
            }
           
        }
        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Pressed left click.");
        //}

        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log(asteroidList.Count);
          foreach(GameObject asteroid in asteroidList)
            {
                Destroy(asteroid);
            }
            asteroidList.Clear();
        }

        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("Pressed middle click.");
        //}
    }
}
