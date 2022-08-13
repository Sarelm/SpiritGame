using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvoThoughtSpawner : MonoBehaviour
{
    public GameObject InvoThoughtGood;
    public GameObject InvoThoughtBad;
    public GameObject ExitPortal;
    public Transform SummonScreen;
    public GameObject PlayerSpirit;
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
        Instantiate(InvoThoughtGood, spawnPosition, Quaternion.identity, SummonScreen);
    }
    void SpawnBadThoughts()
    {
        float spawnY = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(InvoThoughtBad, spawnPosition, Quaternion.identity, SummonScreen);
    }
    void SpawnPortals()
    {
        Debug.Log("Attempting Exit Portal");
        float spawnY = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        Vector2 SpawnPosition = new Vector2(spawnX, spawnY);
        float PortalDistance = Vector2.Distance(PlayerSpirit.transform.position, SpawnPosition);
        float MinDistance = 2.0f;
        bool TooClose = MinDistance >= PortalDistance;
        while (TooClose)
        {
            Debug.Log("Nope! Portal too close.");
            float spawnY1 = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX1 = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
            SpawnPosition = new Vector2(spawnX1, spawnY1);
            PortalDistance = Vector2.Distance(PlayerSpirit.transform.position, SpawnPosition);
            MinDistance = 2.0f;
            TooClose = MinDistance >= PortalDistance;
        }
        if (!TooClose)
        {
            Debug.Log("Exit Here!");
            Instantiate(ExitPortal, SpawnPosition, Quaternion.identity, SummonScreen);
        }
    }
}
