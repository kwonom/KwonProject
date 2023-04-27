using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    public void OnGameStart()
    {
        SceneManager.LoadScene("Main");
    }
}

