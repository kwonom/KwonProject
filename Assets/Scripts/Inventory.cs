using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    void Start()
    {
        
    }

     void Update()
    {
        
    }

    public void OnBtnBlue()
    {
        ColorSave.instance.ColorChange(Color.cyan);
    }

    public void OnBtnPink()
    {
        ColorSave.instance.ColorChange(Color.grey);
    }

    public void OnBtnGreen()
    {
        ColorSave.instance.ColorChange(Color.green);
    }

    public void OnBtnYellow()
    {
        ColorSave.instance.ColorChange(Color.yellow);
    }
}
