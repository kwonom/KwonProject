using UnityEngine;

public class GameManagerUI : MonoBehaviour
{
    [SerializeField] GameObject _onGame;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnGame()
    {
        _onGame.SetActive(_onGame.activeSelf == false);
    }
}
