using UnityEngine;

/**
 * This component helps set the score points an enemy is worth.
 */
public class ScoreHolder : MonoBehaviour
{
    [SerializeField] int points = 1;

    public int GetPoints()
    {
        return points;
    }
}