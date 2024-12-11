using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPoints : MonoBehaviour
{
    int hp = 3; // Intetionally chosen as 3 within the code as it represents the static and non-customizable number of the player's health points.
    [SerializeField] Image hp_image;
    [SerializeField] List<Sprite> hp_types;

    void Start()
    {
        hp_image.sprite = hp_types[3];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("HealthPack"))
        {
            Destroy(other.gameObject);
            Heal();
        }
    }

    public int GetHP()
    {
        return hp;
    }

    public void Hit()
    {
        if (hp > 0)
        {
            hp--;
        }
        
        spriteChange();
    }

    public void Heal()
    {
        if (hp < 3) 
        {
            hp++;
        }
        
        spriteChange();
    }

    void spriteChange()
    {
        hp_image.sprite = hp_types[hp];
    }
}