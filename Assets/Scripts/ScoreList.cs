using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreList : MonoBehaviour
{
    [SerializeField] CSVController _csvCon;

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
        Time.timeScale =1;
        SceneManager.LoadScene("Lobby");
    }

    //public void ShowList(RankingData data)
    //{
        

    //}
}
