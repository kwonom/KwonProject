using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] InputField _text;
    [SerializeField] ScoreList _scorePanel;
    
    
    string PlayerName = null;
    int score = 0;

    public void SetScore(int x)
    {
        score = x;
    }

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NameButton()
    {
        PlayerName = _text.text;
        // �÷��̾� �̸�, ���ھ� ����
        Debug.Log(_text.text);
        
        _scorePanel.gameObject.SetActive(true);
        _scorePanel.ShowList();
    }
}
