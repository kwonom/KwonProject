using UnityEngine;

public class ColorSave : MonoBehaviour
{
    public static ColorSave instance;
    Color _color;
    Sprite _sprite;
    float _xScale;
    float _yScale;

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

    public void SpriteChange(Sprite sprite)
    {
        _sprite = sprite;
    }

    public void XScaleChage(float xScale)
    {
        _xScale = xScale;
    }

    public void YScaleChange(float yScale)
    {
        _yScale = yScale;
    }

    public Color GetColor()
    {
        return _color;
    }

    public Sprite GetSprite()
    {
        return _sprite;
    }

    public float GetX()
    {
        return _xScale;
    }

    public float GetY()
    {
        return _yScale;
    }
}

