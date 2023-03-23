using System.Collections;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] float xjump;
    [SerializeField] float yjump;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject _endpanel;

    bool _isGameover = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-xjump, yjump);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(xjump, yjump);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Time.timeScale = 0;
            StartCoroutine(CoBrickDead());
            _endpanel.SetActive(true);
        }
    }

    IEnumerator CoBrickDead()
    {
        _isGameover = true;

        while (_isGameover)
        {
            rb.gravityScale = 1;
            yield return new WaitForSecondsRealtime(1.5f);
            Time.timeScale = 1;
        }
    }

}
