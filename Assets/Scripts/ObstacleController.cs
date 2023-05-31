using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] GameObject _obstacle;
    
    float _timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > 3)
        {
            _timer = 0;

            GameObject obs = Instantiate(_obstacle);

            obs.transform.position = new Vector3(-17, 20, 0);
        }
        Debug.Log("장애물 생성");
    }
}
