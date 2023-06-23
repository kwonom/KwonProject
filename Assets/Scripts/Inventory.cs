using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] Transform _content;

    public void OnBtnBlue()
    {
        ColorSave.instance.ColorChange(new Color(4/255f, 221/255f, 255/255f, 1));
        Debug.Log("블루색이 선택되었습니다.");
    }

    public void OnBtnPink()
    {
        ColorSave.instance.ColorChange(new Color(245/255f, 36/255f, 220/255f, 1));
    }

    public void OnBtnGreen()
    {
        ColorSave.instance.ColorChange(new Color(86/255f, 248/255f, 11/255f, 1));
    }

    public void OnBtnYellow()
    {
        ColorSave.instance.ColorChange(new Color(254/255f, 255/255f, 0/255f, 1));
    }

    public void OnBtnColorSelect()
    {
        
    }
}
