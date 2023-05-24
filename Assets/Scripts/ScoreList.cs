using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreList : MonoBehaviour
{
    [SerializeField] CSVController _csvCon;
    [SerializeField] GameObject _item;
    [SerializeField] Transform _content;

    List<GameObject> lstItems = new List<GameObject>();

    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }

    public void ToLobby()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Lobby");
    }

    public void ShowList()
    {
        var datas = from data in _csvCon._lstRanking
                    orderby data.GetScore() descending
                    select data;
        int count = 1;
        foreach (RankingData data in datas.Take(5))
        {
            GameObject temp = Instantiate(_item, _content);
            temp.GetComponent<SetItem>().Init(data, count++);
            lstItems.Add(temp);
        }
    }
}
