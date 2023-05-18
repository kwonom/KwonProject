using UnityEngine;
using UnityEngine.UI;

public class SetItem : MonoBehaviour
{
    [SerializeField] Image _image;
    [SerializeField] Text _Nametext;
    [SerializeField] Text _scoreText;

    RankingData _data;

    public void Init(RankingData data)
    {
        _data = data;
        _Nametext.text = "�̸� : " + data.GetName();
        _scoreText.text = "���� : " + data.GetScore();
    }
}
