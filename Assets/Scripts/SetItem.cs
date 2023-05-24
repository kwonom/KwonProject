using UnityEngine;
using UnityEngine.UI;

public class SetItem : MonoBehaviour
{
    [SerializeField] Text _Nametext;
    [SerializeField] Text _scoreText;
    [SerializeField] Text _rankText;
    [SerializeField] Image _image;
    
    RankingData _data;

    public void Init(RankingData data, int rank)
    {
        _rankText.text = rank.ToString();
        _data = data;
        _Nametext.text = data.GetName();
        _scoreText.text = data.GetScore().ToString();
    }
}
