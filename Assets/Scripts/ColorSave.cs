using UnityEngine;
using UnityEngine.UI;

public class ColorSave : MonoBehaviour
{
    public static ColorSave instance;
    Color _color;

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

