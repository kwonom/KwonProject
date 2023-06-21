using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;
    [SerializeField] AudioClip _BGM;
    [SerializeField] AudioClip _Fx;
    [SerializeField] AudioClip _Fx2;
    [SerializeField] AudioSource _BGMPlayer;
    [SerializeField] AudioSource _fxPlayer;
    [SerializeField] AudioSource _fxPlayer2;
    [SerializeField] Slider _BGMSlider;
 
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        _BGMPlayer.mute = false;
        _BGMPlayer.volume = 1f;
        _BGMSlider.value = 1f;
    }

    public void OnbgmMute()
    {
        _BGMPlayer.mute = !_BGMPlayer.mute;
    }

    public void OnBtnPlayBgm()
    {
        _BGMPlayer.clip = _BGM;
        _BGMPlayer.Play();
        _BGMSlider.gameObject.SetActive(true);
    }

    public void OnBtnPlayFx()
    {
        _fxPlayer.clip = _Fx;
        _fxPlayer.Play();
    }

    public void OnBtnPlayFx2()
    {
        _fxPlayer2.clip = _Fx2;
        _fxPlayer2.Play();
    }

    public void OnbgmVolumeChange()
    {
        _BGMPlayer.volume = _BGMSlider.value;
    }
}
