using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] InputField _text;
    [SerializeField] ScoreList _scorePanel;
    [SerializeField] CSVController _csvCon;

    string PlayerName = null;
    int score = 0;

    public void SetScore(int x)
    {
        score = x;
    }

    public void NameButton()
    {
        RankingData data = new RankingData();
        data.SetData(_text.text, score);
        PlayerName = _text.text;
        _csvCon._lstRanking.Add(data);
        _csvCon.WriteCSV();
        _scorePanel.gameObject.SetActive(true);
        _scorePanel.ShowList();
    }
}
