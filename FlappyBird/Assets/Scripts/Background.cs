using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 0;
    Renderer rd;
    private void Start()
    {
        rd = GetComponent<Renderer>();
    }
    void Update()
    {
        rd.material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
    }
}
