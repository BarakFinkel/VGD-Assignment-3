using UnityEngine;

public class SpawnerAroundPlayer : TimedSpawnerRandom
{
    [Tooltip("Radius of the horizontal spread in the X direction.")]
    [SerializeField]
    float spawnRadius = 8.0f;

    [Tooltip("Height of the vertical spread in the Y direction.")]
    [SerializeField]
    float spawnHeight = 6.0f;

    [Tooltip("Factor of max height for minimum spawning height.")]
    [SerializeField]
    float coneFactor = 0.2f;

    // Override the SpawnRoutine to adjust the spawn logic
    protected override async void SpawnRoutine()
    {
        while (true)
        {
            float timeBetweenSpawnsInSeconds = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            await Awaitable.WaitForSecondsAsync(timeBetweenSpawnsInSeconds);  // co-routines
            
            if (!this)
            {
                break;  // might be destroyed when moving to a new scene
            }

            // Random Y position within the height of the capsule
            float yOffset = Random.Range(coneFactor * spawnHeight, spawnHeight);

            // Random X position within the height of the capsule
            float xOffset = Random.Range(-spawnRadius, spawnRadius);

            // Combine the random offsets to form the spawn position in 2D
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + xOffset,
                transform.position.y + yOffset,
                transform.position.z  
            );

            // Instantiate and set up the spawned object as before
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            newObject.transform.parent = parentOfAllInstances;
        }
    }
}