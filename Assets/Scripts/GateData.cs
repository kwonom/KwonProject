using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateData : MonoBehaviour
{
    [SerializeField] float height;
    

    public float getGate()
    {
        return height;
    }
}
