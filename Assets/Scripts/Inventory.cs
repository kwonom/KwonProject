using UnityEngine;

public enum EPlayerState
{
    Black,
    Blue,
    Green,
}
public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

     void Update()
    {
        
    }
}
