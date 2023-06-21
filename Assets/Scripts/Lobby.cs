using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    [SerializeField] GameObject _optionPanel;
    [SerializeField] GameObject _InventoryPanel;
    [SerializeField] Slider _slider;
 
    public void OnGameStart()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnOptionButton()
    {
        _optionPanel.SetActive(!_optionPanel.activeSelf);
    }

    public void OnInventoryButton()
    {
        _InventoryPanel.SetActive(!_InventoryPanel.activeSelf);
    }
}

