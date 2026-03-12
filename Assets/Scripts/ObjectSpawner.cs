using Unity.VisualScripting;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject SpawnerObject;
    private GameObject Clone;
    public float ladySpawn = 5f;
    public float spawnInterval = 4f;

	public GameObject PowerUpOne;
	[SerializeField] private float powerUpOneSpawnInterval;

	public GameObject PowerUpTwo;
    [SerializeField] private float powerUpTwoSpawnInterval;

    private GameObject PowerUpClone;

	public Vector2 spawnArea = new Vector2(0, 0);

    private void Awake()
    {
        powerUpOneSpawnInterval = Random.Range(10f, 30f);
        powerUpTwoSpawnInterval = Random.Range(10f, 30f);
    }

	void FixedUpdate()
    {
        // neemt een random plek tussen deze waardes waar het game object gespawned kan worden
        spawnArea[0] = Random.Range(-7.5f, 7.5f);
        spawnArea[1] = Random.Range(6f, 9f);

        ladySpawn -= Time.deltaTime;
        if (ladySpawn <= 0f)
        {
            Clone = Instantiate(SpawnerObject, spawnArea, Quaternion.identity);
            ladySpawn = spawnInterval;
        }

        powerUpOneSpawnInterval -= Time.deltaTime;
        if (powerUpOneSpawnInterval <= 0f)
        {
            PowerUpClone = Instantiate(PowerUpOne, spawnArea, Quaternion.identity);
			powerUpOneSpawnInterval = Random.Range(10f, 30f);
		}

		powerUpTwoSpawnInterval -= Time.deltaTime;
        if (powerUpTwoSpawnInterval <= 0f)
        {
            PowerUpClone = Instantiate(PowerUpTwo, spawnArea, Quaternion.identity);
			powerUpTwoSpawnInterval = Random.Range(10f, 30f);
		}
	}
}
