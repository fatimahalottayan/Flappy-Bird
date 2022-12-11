using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR : MonoBehaviour
{
    public float scrollSpeed =0.05f;

    private Renderer rend;
    private Vector2 savedOffset;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float x = Time.time * scrollSpeed;
        Vector2 offset = new Vector2(x, 0);
        rend.material.mainTextureOffset =offset;
    }
}
