using UnityEngine;

public class SpawnGate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Brick")
        {
            collision.GetComponent<Brick>().spGate();
        }    
    }
}
