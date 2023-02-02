using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    bool isGround = false;
    bool isFalling = true;
    bool bounce = false;
    float timer = 0f;
    float _bounce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
            isFalling = false;
            bounce = false;
            //jumpCount = 2;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        jumping();
    }

    void jumping()
    {
        if (!bounce)
        {
            //transform.position += Vector3.up * Time.deltaTime * 10;
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 500);
            bounce = true;
        }
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 150);
            //gameObject.transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 150);
            //transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (!isGround)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                isFalling = true;
            }
        }
        if (!isGround && !isFalling) return;
        if (Input.GetKeyDown(KeyCode.Space)) timer = 0.3f;
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate(Vector3.up * Time.deltaTime * 10);
            transform.position += Vector3.up * Time.deltaTime * 10;
            isGround = false;

        }
        if (Input.GetKeyDown(KeyCode.Space)) isFalling = true;
    }
}
