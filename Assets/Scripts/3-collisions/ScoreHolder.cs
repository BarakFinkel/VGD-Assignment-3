using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreHolder : MonoBehaviour {
    [SerializeField] int points = 1;

    public int GetPoints()
    {
        return points;
    }
}