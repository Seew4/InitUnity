using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourChanger : MonoBehaviour
{
    public SpriteRenderer rend;
    public TrailRenderer trailrend;
    public Color color;


    // Use this for initialization
    void Start()
    {
        rend.color = color;
        rend.color = new Color(0.5f, 0.1f, 0.5f);

        transform.position = new Vector3(-5f, transform.position.y);

        transform.Translate(-5f, 0f, 0f, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -360f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 360f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(4f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-4f * Time.deltaTime, 0, 0, Space.Self);
        }


    }
}
