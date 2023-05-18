using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreList : MonoBehaviour
{
    [SerializeField] CSVController _csvCon;
    [SerializeField] GameObject _item;
    [SerializeField] Transform _content;

    List<GameObject> lstItems = new List<GameObject>();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
        foreach (RankingData data in _csvCon._lstRanking)
        {
            GameObject temp = Instantiate(_item, _content);
            temp.GetComponent<SetItem>().Init(data);
            lstItems.Add(temp);
        }


    }
}
