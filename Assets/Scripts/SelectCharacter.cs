using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public static SelectCharacter instance;
    Sprite _sprite;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
