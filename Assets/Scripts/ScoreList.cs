using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreList : MonoBehaviour
{
    // Start is called before the first frame update
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

    public void ShowList()
    {
        // 점수 목록 보여주기
    }
}
