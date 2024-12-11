using UnityEngine;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 */
public class LaserShooter : ClickSpawner
{
    protected override GameObject spawnObject()
    {
        GameObject newObject = base.spawnObject();  // base = super

        // Assign a player reference to the ScoreAdder component.
        ScoreAdder scoreAdder = newObject.GetComponent<ScoreAdder>();

        if (scoreAdder != null)
        {
            scoreAdder.player = gameObject; // Assign the Player reference
        }

        return newObject;
    }
}