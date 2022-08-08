using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }
    private TextMeshProUGUI ScoreText;
    public static int ScoreNum = 0;
    public static string TheType = "";

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
        ScoreNum = 0;
        TheType = "";
    }
    void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
        ScoreText.GetComponent<TextMeshProUGUI>().SetText(ScoreNum.ToString());
        string Game = gameObject.scene.name;
        switch (Game)
        {
            case "NecroGame":
                Debug.Log("Summoning a Necromist Spirit");
                TheType = "Necromist";
                break;
            case "EcoGame":
                Debug.Log("Summoning an Ecolist Spirit");
                TheType = "Ecolist";
                break;
            case "InvoGame":
                Debug.Log("Summoning an Invokist Spirit");
                TheType = "Invokist";
                break;
            case "ChronoGame":
                Debug.Log("Summoning a Chronolist Spirit");
                TheType = "Chronolist";
                break;
        }
    }

    void Update()
    {
        ScoreText.GetComponent<TextMeshProUGUI>().SetText(ScoreNum.ToString());
        if (ScoreNum >= 100)
        {
            SceneManager.LoadScene("SummonWin");
        }
    }
}