using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float spd = 5.0f;
    float h;
    float v;
    private Rigidbody2D rb;

    // jestem przyzwyczajony do C++
    void printf(string text)
    {
        Debug.Log(text);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(h * spd, v * spd);
    }
}
