using UnityEngine;

public class LifeTime : MonoBehaviour
{
            
    [SerializeField]
    [Tooltip("Time length of object's existence")]
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
