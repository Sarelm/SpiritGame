using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChronoThoughtsScript : MonoBehaviour
{
    public static ChronoThoughtsScript Instance { get; private set; }
    public static TextMeshProUGUI ChronoMasterTerm;
    public static string Nowles;
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
        var Term = ChronoTerm();
        Nowles = Term;
        ChronoMasterTerm = gameObject.GetComponent<TextMeshProUGUI>();
        ChronoMasterTerm.text = "Thoughts that are: " + Term;
    }
    public static string ChronoTerm()
    {
        string[] ChronoTerms =
        {
            "Prime Numbers",
            "Divisible by 3.",
            "Square Numbers"
        };
        int ChronoTermNum = Random.Range(0, ChronoTerms.Length);
        string PickChronoTerm = ChronoTerms[ChronoTermNum];
        return PickChronoTerm;
    }
    public static string GetTerms()
    {
        string Terms = "";
        if (Nowles == "Prime Numbers")
        {
            Debug.Log("All Primed");
            string[] PrimeTerms =
            {
            "5",
            "17",
            "11",
            "23",
            "31",
            "47",
            "53",
            "67",
            "73",
            "89"
            };
            int PrimeTermsNum = Random.Range(0, PrimeTerms.Length);
            Terms = PrimeTerms[PrimeTermsNum];
        }
        if (Nowles == "Divisible by 3.")
        {
            Debug.Log("Trifecta");
            string[] TriTerms =
            {
            "39",
            "123",
            "96",
            "24",
            "81",
            "105",
            "48",
            "51",
            "45",
            "72"
            };
            int TriTermsNum = Random.Range(0, TriTerms.Length);
            Terms = TriTerms[TriTermsNum];
        }
        if (Nowles == "Square Numbers")
        {
            Debug.Log("Squared");
            string[] SquareTerms =
            {
            "4",
            "9",
            "16",
            "25",
            "36",
            "49",
            "64",
            "81",
            "100"
            };
            int SquareTermsNum = Random.Range(0, SquareTerms.Length);
            Terms = SquareTerms[SquareTermsNum];
        }
        return Terms;
    }
    public static string GetBadTerms()
    {
        string BadTerms = "";
        if (Nowles == "Prime Numbers")
        {
            Debug.Log("Not Primed");
            string[] NotPrimedTerms =
            {
            "6",
            "15",
            "28",
            "81",
            "123",
            "51",
            "105",
            "9",
            "63",
            "27"
            };
            int NotPrimedNum = Random.Range(0, NotPrimedTerms.Length);
            BadTerms = NotPrimedTerms[NotPrimedNum];
        }
        if (Nowles == "Divisible by 3.")
        {
            Debug.Log("No Trifecta");
            string[] NotTriTerms =
            {
            "55",
            "61",
            "83",
            "13",
            "16",
            "20",
            "25",
            "34",
            "101",
            "97",
            "112"
            };
            int NotTriTNum = Random.Range(0, NotTriTerms.Length);
            BadTerms = NotTriTerms[NotTriTNum];
        }
        if (Nowles == "Square Numbers")
        {
            Debug.Log("Not Squared");
            string[] NotSquareTerms =
            {
            "55",
            "61",
            "83",
            "13",
            "18",
            "20",
            "28",
            "34",
            "101",
            "97",
            "108"
            };
            int NotSquareTNum = Random.Range(0, NotSquareTerms.Length);
            BadTerms = NotSquareTerms[NotSquareTNum];
        }
        return BadTerms;
    }
}
