using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab of the enemy to spawn
    public float spawnInterval = 2f; // Interval between spawns
    public float spawnRange = 10f; // Maximum distance from the player to spawn enemies

    private float timer;
    private Transform playerTransform;

    void Start()
    {
        // Find the player GameObject in the scene
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if it's time to spawn a new enemy
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f; // Reset the timer
        }
    }

    void SpawnEnemy()
    {
        // Calculate a random position within the spawn range around the player
        Vector3 randomDirection = Random.insideUnitSphere.normalized * spawnRange;
        Vector3 spawnPosition = playerTransform.position + randomDirection;

        // Instantiate the enemy at the calculated position
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Optionally, you can set up any enemy-specific properties here
        // For example, you might want to set health or speed.
    }
}
