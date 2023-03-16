using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    [SerializeField] GameObject[] _gates;     

    // Start is called before the first frame update
    void Start()
    {
        makeGate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Brick")
        {
            Debug.Log("게이트 생성");
        }
    }
    public void makeGate()
    {
        for(int i = 0; i < _gates.Length; i++)
        {
            _gates[i].gameObject.SetActive(true);
            
            Instantiate(_gates[i]);
        }
    }
}
