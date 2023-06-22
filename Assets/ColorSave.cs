using UnityEngine;
using UnityEngine.UI;

public class ColorSave : MonoBehaviour
{
    public static ColorSave intance;
    Color _color;

    private void Awake()
    {
        if(intance == null)
        {
            intance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void ColorChange(Color color)
    {
        _color = color;
        
    }

    public Color GetColor()
    {
        return _color;
    }
}

