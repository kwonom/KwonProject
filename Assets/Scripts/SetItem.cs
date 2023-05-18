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
        _Nametext.text = "이름 : " + data.GetName();
        _scoreText.text = "점수 : " + data.GetScore();
    }
}
