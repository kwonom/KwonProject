using UnityEngine;

public class SpawnGate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Brick")
        {
            Debug.Log("게이트 생성");
            collision.GetComponent<Brick>().spGate();
        }    
    }
}
