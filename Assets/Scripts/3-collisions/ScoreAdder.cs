using System.Collections.Generic;
using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    [SerializeField] List<string> triggeringTags;
    public GameObject player;
    NumberField scoreField;

    void Start()
    {
        scoreField = GetComponent<NumberField>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (triggeringTags.Contains(other.gameObject.tag))
        {
            ScoreHolder enemyScorer = other.gameObject.GetComponent<ScoreHolder>();
            int addedPoints = enemyScorer.GetPoints();
            DoublePoints dp = player.GetComponent<DoublePoints>();

            if(dp != null && dp.IsDouble())
            {
                Debug.Log("Double up!");
                addedPoints *= 2;
            }

            scoreField.AddNumber(addedPoints);
        }
    }
}