using System.Collections;
using UnityEngine;
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

    void Start()
    {
        Application.targetFrameRate = 30;
        Time.timeScale = 0;
        GetComponent<SpriteRenderer>().color = ColorSave.instance.GetColor();
        GetComponent<SpriteRenderer>().sprite = ColorSave.instance.GetSprite();
        transform.localScale = new Vector3(ColorSave.instance.GetX(), ColorSave.instance.GetY(), 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-xjump, yjump);
            OnGameStart();
            _isGameStart = true;
            SoundController.instance.OnBtnPlayFx();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(xjump, yjump);
            OnGameStart();
            _isGameStart = true;
            SoundController.instance.OnBtnPlayFx();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            SoundController.instance.OnBtnPlayFx2();
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
    }

    public void OptionOpen()
    {
        Time.timeScale = 0;
        _OptionUI.SetActive(true);
        _OptionUI.GetComponent<GameUI>().SetScore(score);
    }

    void OnGameStart()
    {
        if (_isGameStart == false)
        {
            Time.timeScale = 2.2f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_isGameStart == true && _isGameover == false)
        {
            score++;
            _scoreText.text = "Score : " + score;
        }
    }

    public void spGate()
    {
        _GCon.SpawnGate();
    }
}
