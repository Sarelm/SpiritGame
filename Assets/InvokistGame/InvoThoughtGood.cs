using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InvoThoughtGood : MonoBehaviour
{
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
            Debug.Log("InvoThink");
            string TheWord = InvoThoughtsScript.GetTerms();
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