using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ThoughtGood : MonoBehaviour
{
    public GameObject ChronoThoughts;
    public GameObject InvoThoughts;
    private TextMeshProUGUI Word;
    private float SpawnTime;
    public float AutoDestroyTime = 5f;
    private void Start()
    {
            Word = gameObject.GetComponent<TextMeshProUGUI>();
            Word.text = GetWord();

        string GetWord()
        {
            Debug.Log("Here's the Good");
            string TheWord = "";
            if (InvoThoughts.gameObject.activeSelf)
            {
                Debug.Log("InvoThink");
                TheWord = InvoThoughtsScript.GetTerms();
            }
            if (ChronoThoughts.gameObject.activeSelf)
            {
                Debug.Log("ChronoThink");
                TheWord = ChronoThoughtsScript.GetTerms();
            }
            else
            {
                Debug.Log("Where the fuck are they?");
            }
            return TheWord;
        }
    }
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
}