using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _scrollRange;
    [SerializeField] float _speed;
    [SerializeField] Vector3 _movedir = Vector3.down;

    private void Update()
    {
        transform.position += _movedir * _speed * Time.deltaTime;

        if(transform.position.y <= - _scrollRange)
        {
            transform.position = _target.position + Vector3.up.normalized * _scrollRange;
        }
    }
}
