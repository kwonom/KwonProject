using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(0, _target.position.y - transform.position.y).normalized * _speed;
    }
}
