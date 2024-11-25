using TMPro;
using UnityEngine;

public class DoublePoints : MonoBehaviour
{
    bool doubleUp = false;
    [SerializeField] float doubleDuration = 5.0f;
    TMP_Text doubleText;

    void Start()
    {
        doubleText = GameObject.Find("DoubleP").GetComponent<TMP_Text>();
        if (CompareTag("Player"))
        {
            doubleText.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (CompareTag("Player") && other.gameObject.CompareTag("Double"))
        {
            Destroy(other.gameObject);
            TurnOnDouble();
        }
    }

    public bool IsDouble()
    {
        return doubleUp;
    }

    public void TurnOnDouble()
    {
        doubleUp = true;
        doubleText.enabled = true;

        Invoke(nameof(TurnOffDouble), doubleDuration);
    }

    public void TurnOffDouble()
    {
        doubleText.enabled = false;
        doubleUp = false;
    }
}