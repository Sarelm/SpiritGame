using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ThoughtBad : MonoBehaviour
{
    public GameObject InvoThoughts;
    public GameObject ChronoThoughts;
    private TextMeshProUGUI Word;
    public static string TheType;
    private float SpawnTime;
    public float AutoDestroyTime = 5f;

    private void Start()
    {
        Word = gameObject.GetComponent<TextMeshProUGUI>();
        Word.text = GetBadWord();

        string GetBadWord()
        {
            Debug.Log("Here's The Bad");
            string TheBadWord = "";
            if (InvoThoughts.gameObject.activeSelf)
            {
                Debug.Log("Not InvoThink");
                TheType = "Invokist";
                TheBadWord = InvoThoughtsScript.GetBadTerms();
            }
            if (ChronoThoughts.gameObject.activeSelf)
            {
                Debug.Log("Not ChronoThink");
                TheType = "Chronolist";
                TheBadWord = ChronoThoughtsScript.GetBadTerms();
            }
            else
            {
                Debug.Log("The bad thoughts, we lost'm");
            }
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
