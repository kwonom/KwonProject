using UnityEngine;

public class GateData : MonoBehaviour
{
    [SerializeField] float height;
    
    public float getGate()
    {
        return height;
    }
}
