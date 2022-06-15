using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public float spawnInterval;
    public Transform spawnArea;
    public Vector2 MaxPUPosition;
    public Vector2 MinPUPosition;
    public List<GameObject> powerUpTemplateList;

    private List<GameObject> powerUpList;
    private float timer;

    private void Start()
    {
        timer = 0;
        powerUpList = new List<GameObject>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnInterval)
        {
            GenerateRandomPU();
            timer -= spawnInterval;
        }
    }

    public void GenerateRandomPU()
    {
        GenerateRandomPU(new Vector2(Random.Range(MinPUPosition.x, MaxPUPosition.x), Random.Range(MinPUPosition.y, MaxPUPosition.y)));
    }

    public void GenerateRandomPU(Vector2 position)
    {
        if(position.x < MinPUPosition.x || position.x > MaxPUPosition.x ||
           position.y < MinPUPosition.y || position.y > MaxPUPosition.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y ,powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);

        powerUp.SetActive(true);
        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
}
