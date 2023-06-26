using UnityEngine;
using UnityEngine.UI;

public class ItemContainer : MonoBehaviour
{
    [SerializeField] Image _image;
    ItemData _data;
    Inventory _parent;
    public void Init(ItemData data, Inventory inven)
    {
        _data = data;
        _image.color = data.Color;
        _image.sprite = data.Shape;
        _parent = inven;
    }

    public void OnButton()
    {
        _parent.OnBtnColorSelect(_data);
    }
}
