using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] Sprite[] _sprites; // 0·ºÅÊ±Û, 1 »ï°¢Çü, 2 µ¿±×¶ó¹Ì
    [SerializeField] GameObject _item;
    [SerializeField] Transform _content;

    private void Start()
    {
        List<ItemData> _lstData = new List<ItemData>()
        {
            new ItemData(new Color(100/255f, 61/255f, 255/255f, 1), _sprites[0]),
            new ItemData(Color.yellow, _sprites[1], 1.3f, 1.3f),
            new ItemData(Color.green, _sprites[2], 1.3f, 1.3f),
            new ItemData(new Color(4/255f, 221/255f, 255/255f, 1), _sprites[3], 1.5f, 1.5f),
            new ItemData(new Color(245 / 255f, 36 / 255f, 220 / 255f, 1), _sprites[4]),
            new ItemData(new Color(253/255f, 145/255f, 23/255f, 1), _sprites[5], 1.3f, 1.3f)
        };
        for(int i = 0; i < _lstData.Count; i++)
        {
            GameObject obj =  Instantiate(_item, _content);
            obj.GetComponent<ItemContainer>().Init(_lstData[i], this);
        }
    }

    public void OnBtnColorSelect(ItemData data)
    {
        ColorSave.instance.ColorChange(data.Color);
        ColorSave.instance.SpriteChange(data.Shape);
        ColorSave.instance.XScaleChage(data.xScale);
        ColorSave.instance.YScaleChange(data.yScale);
    }
}

public class ItemData
{
    Color _color;
    Sprite _shape;
    float _xScale;
    float _yScale;
    public Color Color { get { return _color; } }
    public Sprite Shape { get { return _shape; } }

    public float xScale { get { return _xScale; } }

    public float yScale { get { return _yScale; } }

    public ItemData(Color color, Sprite shape, float xsacle = 1f, float yscale = 1f)
    {
        _color = color;
        _shape = shape;
        _xScale = xsacle;
        _yScale = yscale;
    }
}