using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcoThoughtSpawner : MonoBehaviour
{
    public GameObject EcoThoughtGood;
    public GameObject EcoThoughtBad;
    public GameObject ExitPortal;
    public Transform SummonScreen;
    private void Start()
    {
        InvokeRepeating("SpawnThoughts", 1, 2f);
        InvokeRepeating("SpawnBadThoughts", 3, 3f);
        InvokeRepeating("SpawnPortals", 8, 8f);
    }
    void SpawnThoughts()
    {
        float spawnY = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(EcoThoughtGood, spawnPosition, Quaternion.identity, SummonScreen);
    }
    void SpawnBadThoughts()
    {
        float spawnY = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(EcoThoughtBad, spawnPosition, Quaternion.identity, SummonScreen);
    }
    void SpawnPortals()
    {
        float spawnY = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(ExitPortal, spawnPosition, Quaternion.identity, SummonScreen);
    }
}