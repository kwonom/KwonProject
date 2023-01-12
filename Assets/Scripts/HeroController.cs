using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

enum EMoveType
{
    Idle,
    Up,
}

public class HeroController : MonoBehaviour
{
    [SerializeField] float speed;
    Animator _ani;
    // Start is called before the first frame update
    void Start()
    {
        _ani.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
    }
}
