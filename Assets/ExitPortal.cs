using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ExitPortal : MonoBehaviour
{
    private float SpawnTime;
    public float AutoDestroyTime = 8f;
    private void OnEnable()
    {
        SpawnTime = Time.time;
    }
    private void Update()
    {
        float remainingTime = (SpawnTime + AutoDestroyTime) - Time.time;
        if (remainingTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerSpirit"))
        {
            Debug.Log("Got One");
            SceneManager.LoadScene("SummonWin");
        }
    }
}