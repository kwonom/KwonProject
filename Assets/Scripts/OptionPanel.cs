using UnityEngine;
using UnityEngine.UI;

public class OptionPanel : MonoBehaviour
{
    [SerializeField] Slider _BGMSlider;
    private void Start()
    {
        SoundController.instance.Init(_BGMSlider);
    }
    
    public void OnValueChange()
    {
        SoundController.instance.OnbgmVolumeChange();
    }
    public void SliderOnOff()
    {
        _BGMSlider.gameObject.SetActive(!_BGMSlider.gameObject.activeSelf);
    }

    public void OnBgmMute()
    {
        SoundController.instance.OnbgmMute();
    }
}
