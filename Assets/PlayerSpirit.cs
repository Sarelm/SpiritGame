using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerSpirit : MonoBehaviour
{
    public static PlayerSpirit Instance { get; private set; }
    private float speed = 5f;
    private Vector3 target;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        target = transform.position;
    }
    void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime * (ScoreCounter.ScoreNum/25+1));
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("EcoThoughtGood(Clone)"))
        {
            Debug.Log("MORE EcoPOWAH");
            ScoreCounter.ScoreNum += 2;
        }
        if (collision.name.Equals("NecroThoughtGood(Clone)"))
        {
            Debug.Log("MORE NecroPOWAH");
            ScoreCounter.ScoreNum += 2;
        }
        if (collision.name.Equals("ChronoThoughtsGood(Clone)"))
        {
            Debug.Log("MORE ChronoPOWAH");
            ScoreCounter.ScoreNum += 2;
        }
        if (collision.name.Equals("InvoThoughtGood(Clone)"))
        {
            Debug.Log("MORE InvoPOWAH");
            ScoreCounter.ScoreNum += 2;
        }
        if (collision.name.Equals("EcoThoughtBad(Clone)"))
        {
            Debug.Log("Not that one Eco");
            ScoreCounter.ScoreNum += -1;
        }
        if (collision.name.Equals("NecroThoughtBad(Clone)"))
        {
            Debug.Log("Not that one Necro");
            ScoreCounter.ScoreNum += -1;
        }
        if (collision.name.Equals("ChronoThoughtsBad(Clone)"))
        {
            Debug.Log("Not that one Chrono");
            ScoreCounter.ScoreNum += -1;
        }
        if (collision.name.Equals("InvoThoughtBad(Clone)"))
        {
            Debug.Log("Not that one Invo");
            ScoreCounter.ScoreNum += -1;
        }
        else if (collision.name.Equals("OtherSpirit(Clone)"))
        {
            Debug.Log("Owies");
            SceneManager.LoadScene("SummonFail");
        }
        Destroy(collision.gameObject);
        Debug.Log("That's gone now.");
    }
}