using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    [SerializeField] GameObject _optionPanel;
    [SerializeField] GameObject _InventoryPanel;
    [SerializeField] Slider _slider;
    [SerializeField] Sprite _sprite;


    private void Start()
    {
        ColorSave.instance.ColorChange(Color.black);
        ColorSave.instance.SpriteChange(_sprite);
        ColorSave.instance.XScaleChage(1);
        ColorSave.instance.YScaleChange(1);
    }
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

