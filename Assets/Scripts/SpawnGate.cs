using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Timeline;
using UnityEngine;

public class SpawnGate : MonoBehaviour
{
    [SerializeField] GameObject _gate; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Brick")
        {
            Debug.Log("����Ʈ ����");
        }
    }


    
    // Update is called once per frame
    void Update()
    {
        
    }
}
