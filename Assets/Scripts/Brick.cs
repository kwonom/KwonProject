using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Brick : MonoBehaviour
{
    [SerializeField] float xjump;
    [SerializeField] float yjump;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject _endpanel;
    [SerializeField] GateController _GCon;
    [SerializeField] Text _scoreText;
    [SerializeField] GameObject _OptionUI;

    int score = 0;
    bool _isGameover = false;
    bool _isGameStart = false;
    


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        Time.timeScale = 0;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-xjump, yjump);
            OnGameStart();
            _isGameStart = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(xjump, yjump);
            OnGameStart();
            _isGameStart = true;
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
        yield return null;
        OptionOpen();

        //while (_isGameover)
        //{
        //    rb.gravityScale = 1;
        //    Time.timeScale = 1;
        //    yield return new WaitForSecondsRealtime(2f);
        //    SceneManager.LoadScene("Lobby");
        //}
    }

    void OptionOpen()
    {
        _OptionUI.SetActive(true);
        _OptionUI.GetComponent<GameUI>().SetScore(score);
    }
    void OnGameStart()
    {
        if (_isGameStart == false)
        {
            Time.timeScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_isGameStart == true && _isGameover == false)
        {
            score++;
            Debug.Log(score);
            _scoreText.text = "Score : " + score;
        }
    }

    public void spGate()
    {
        _GCon.SpawnGate();
    }
}
