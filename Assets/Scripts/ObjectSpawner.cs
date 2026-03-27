using UnityEngine;
using System.Collections.Generic;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject SpawnerObject;
    public float ladySpawn = 5f;
    public float spawnInterval = 4f;

	[SerializeField] private GameObject PowerUpOne;
    [SerializeField] private GameObject PowerUpTwo;

    private List<SpawnTimer> SpawnTimers;

	public Vector2 spawnArea = new Vector2(0, 0);

    private void Awake()
    {
        SpawnTimers = new List<SpawnTimer>
        {
            new SpawnTimer(SpawnerObject, spawnInterval, spawnInterval),
            new SpawnTimer(PowerUpOne, 10f, 30f),
            new SpawnTimer(PowerUpTwo, 10, 30f)
        };
    }

	void FixedUpdate()
    {
        spawnArea.x = Random.Range(-7.5f, 7.5f);
        spawnArea.y = Random.Range(6f, 9f);

        foreach (SpawnTimer spawnTimer in SpawnTimers)
        {
            if (spawnTimer.Tick(Time.fixedDeltaTime))
            {
                Instantiate(spawnTimer.prefab, spawnArea, Quaternion.identity);
            }
        }
	}
}
