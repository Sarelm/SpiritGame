using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EcoThoughtsScript : MonoBehaviour
{
    public static EcoThoughtsScript Instance { get; private set; }
    public static TextMeshProUGUI EcoMasterTerm;
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
        var Term = EcoTerm();
        Nowles = Term;
        EcoMasterTerm = gameObject.GetComponent<TextMeshProUGUI>();
        EcoMasterTerm.text = "Thoughts associated with: " + Term;
    }
    public static string EcoTerm()
    {
        string[] EcoTerms =
        {
            "Plants",
            "Cell Division"
        };
        int EcoTermNum = Random.Range(0, EcoTerms.Length);
        string PickEcoTerm = EcoTerms[EcoTermNum];
        return PickEcoTerm;
    }
    public static string GetTerms()
    {
        string Terms = "";
        if (Nowles == "Cell Division")
        { 
        Debug.Log("Dividing Time");
            string[] CellDivisionTerms =
            {
            "Prophase",
            "Metaphase",
            "Anaphase",
            "Telophase",
            "Mitosis",
            "Cytokinesis",
            "Meiosis",
            "Divisome",
            "Centrioles",
            "Centromere",
            "Cell Plate"
            };
        int CellDivisionTermsNum = Random.Range(0, CellDivisionTerms.Length);
        Terms = CellDivisionTerms[CellDivisionTermsNum];
        }
        if (Nowles == "Plants")
        {
            Debug.Log("Plant Time");
            string[] PlantsTerms =
            {
            "Photosynthesis",
            "Chloroplast",
            "Cell Wall",
            "Phloem",
            "Angiosperm",
            "Gymnosperm",
            "Stamen",
            "Pistil",
            "Inflorescence",
            "Bract",
            "Glyoxysomes",
            "Plastids",
            "Plasmodesmata"
            };
            int PlantsTermsNum = Random.Range(0, PlantsTerms.Length);
            Terms = PlantsTerms[PlantsTermsNum];
        }
        return Terms;
    }
    public static string GetBadTerms()
    {
        string BadTerms = "";
        if (Nowles == "Plants")
        {
            Debug.Log("Not a Plant Thing.");
            string[] NotPlantTerms =
            {
                "Muscle",
                "Cilia",
                "Myocyte",
                "Osteocyte",
                "Myofibril",
                "Sarcolemma",
                "Sarcomere",
                "Myosin",
                "Osteoblast",
                "Myogenic"
            };
            int NotPlantNum = Random.Range(0, NotPlantTerms.Length);
            BadTerms = NotPlantTerms[NotPlantNum];
        }
        if (Nowles == "Cell Division")
        {
            Debug.Log("Not Dividing Times");
            string[] NotCellDivisionTerms =
            {
                "Tendon",
                "Virion",
                "Monopartite",
                "Nucleocapsid",
                "Lytic Cycle",
                "Retroviridae",
                "Picornoviridae",
                "Capsomere",
                "Necrosis",
                "Apoptosis"
            };
            int NotCellDivisionNum = Random.Range(0, NotCellDivisionTerms.Length);
            BadTerms = NotCellDivisionTerms[NotCellDivisionNum];
        }
        return BadTerms;
    }
}