using UnityEngine;

public class BackGroundBase : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _scrollRange;
    [SerializeField] float _speed;
    [SerializeField] Vector3 _movedir = Vector3.down;

    void Update()
    {
        transform.position += _movedir * _speed * Time.deltaTime;

        if(transform.position.y <= -_scrollRange)
        {
            transform.position = _target.position + Vector3.up.normalized * _scrollRange;
        }
    }
}
