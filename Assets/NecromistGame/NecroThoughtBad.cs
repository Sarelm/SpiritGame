using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NecroThoughtBad : MonoBehaviour
{
    public GameObject NecroThoughts;
    private TextMeshProUGUI Word;
    private float SpawnTime;
    public float AutoDestroyTime = 5f;

    private void Start()
    {
        Word = gameObject.GetComponent<TextMeshProUGUI>();
        Word.text = GetBadWord();

        string GetBadWord()
        {
            Debug.Log("Not NecroThink");
            string TheBadWord = NecroThoughtsScript.GetBadTerms();
            return TheBadWord;
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
