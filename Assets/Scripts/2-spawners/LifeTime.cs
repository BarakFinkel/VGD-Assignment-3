using UnityEngine;

public class LifeTime : MonoBehaviour
{    
    [Tooltip("Time length of object's existence")]    
    [SerializeField]
    float lifeTime = 1.0f;

    void Start()
    {
        Invoke(nameof(DestroyMe), lifeTime);
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
