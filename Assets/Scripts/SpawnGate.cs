using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Timeline;
using UnityEngine;

public class SpawnGate : MonoBehaviour
{
    float sumHeight = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Brick")
        {
            Debug.Log("게이트 생성");
            collision.GetComponent<Brick>().spGate();
        }    
    }
}
