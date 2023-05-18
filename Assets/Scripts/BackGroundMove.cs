using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    [SerializeField] Transform _target;
   
    void Update()
    {
        Vector3 gPos = transform.position;
        gPos.y = _target.position.y;
        transform.position = gPos;
    }
}
