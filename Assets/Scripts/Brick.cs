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
    float _lifetimer;
    bool _isGameover = false;
    bool _isGameStart = false;

    void Start()
    {
        Application.targetFrameRate = 30;
        Time.timeScale = 0;
        Debug.Log("브릭에서 호출되었습니다.");
        GetComponent<SpriteRenderer>().color = ColorSave.intance.GetColor();
    }

    void Update()
    {
        _lifetimer += Time.deltaTime;

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
        if (_lifetimer > 5)
        {
            _lifetimer = 0;
            Time.timeScale = 2.1f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") // 여기까지 진행.
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
            Time.timeScale = 1;
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
