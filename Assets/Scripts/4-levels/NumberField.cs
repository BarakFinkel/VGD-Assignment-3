using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
public class NumberField : MonoBehaviour
{
    TMP_Text score;
    int score_num;

    [System.Obsolete]
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<TMP_Text>();
        score_num = int.Parse(score.text);
    }

    public void SetNumber(int newNumber)
    {
        score_num = newNumber;
        score.text = newNumber.ToString();
    }

    public void AddNumber(int toAdd)
    {
        SetNumber(score_num + toAdd);
    }
}