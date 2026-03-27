using Unity.VisualScripting;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    public GameObject prefab;
    public float interval;
    public float minInterval;
    public float maxInterval;

    private float timer;

    public SpawnTimer(GameObject prefab, float minInterval, float maxInterval)
    {
        this.prefab = prefab;
        this.minInterval = minInterval;
        this.maxInterval = maxInterval;
        this.interval = Random.Range(minInterval, maxInterval);
        this.timer = interval;
    }

    public bool Tick(float deltaTime)
    {
        timer -= deltaTime;
        if (timer <= 0f)
        {
            timer = Random.Range(minInterval, maxInterval);
            return true;
        }

        return false;
    }
}
