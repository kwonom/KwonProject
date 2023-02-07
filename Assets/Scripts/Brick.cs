using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] float xjump;
    [SerializeField] float yjump;
    [SerializeField] Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-xjump, yjump);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(xjump, yjump);
        }

    }
}
