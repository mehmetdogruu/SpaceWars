using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arkaplan : MonoBehaviour
{
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float y = 0.1f * Time.time;
        meshRenderer.material.SetTextureOffset("_MainTex", new Vector2(0, y));

    }
}
