using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] GameObject _obstacle;
    [SerializeField] Transform _target;

    float _timer = 0;

    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > 8)
        {
            _timer = 0;

            Vector3 obspos = transform.position;
            obspos.y = _target.position.y - 10;
            transform.position = obspos;
        }
    }
}
