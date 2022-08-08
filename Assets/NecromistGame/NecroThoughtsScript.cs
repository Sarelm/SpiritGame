using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NecroThoughtsScript : MonoBehaviour
{
    public static NecroThoughtsScript Instance { get; private set; }
    public static TextMeshProUGUI NecroMasterTerm;
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
        var Term = NecroTerm();
        Nowles = Term;
        NecroMasterTerm = gameObject.GetComponent<TextMeshProUGUI>();
        NecroMasterTerm.text = "Thoughts associated with: " + Term;
    }
    public static string NecroTerm()
    {
        string[] NecroTerms =
        {
            "A Virus",
            "Muscles"
        };
        int NecroTermNum = Random.Range(0, NecroTerms.Length);
        string PickNecroTerm = NecroTerms[NecroTermNum];
        return PickNecroTerm;
    }
    public static string GetTerms()
    {
        string Terms = "";
        if (Nowles == "A Virus")
        {
            Debug.Log("Viral Things");
            string[] ViralTerms =
            {
            "Capsomere",
            "Lytic Cycle",
            "Virion",
            "Provirus",
            "Prophage",
            "Bacteriophage",
            "Monopartite",
            "Picornaviridae",
            "Retroviridae",
            "Nucleocapsid"
            };
            int ViralTermsNum = Random.Range(0, ViralTerms.Length);
            Terms = ViralTerms[ViralTermsNum];
        }
        if (Nowles == "Muscles")
        {
            Debug.Log("Pump it Up");
            string[] MusclesTerms =
            {
            "Myocyte",
            "Myofibril",
            "Sarcolemma",
            "Sarcomere",
            "Myosin",
            "Myogenic",
            "Sarcoplasmic Reticulum",
            "Myoglobin",
            "Sarcosomes",
            "Tendon"
            };
            int MusclesTermsNum = Random.Range(0, MusclesTerms.Length);
            Terms = MusclesTerms[MusclesTermsNum];
        }
        return Terms;
    }
    public static string GetBadTerms()
    {
        string BadTerms = "";
        if (Nowles == "Muscles")
        {
            Debug.Log("Not Flexing");
            string[] NotFlexTerms =
            {
            "Cell Wall",
            "Phloem",
            "Plasmodesmata",
            "Gymnosperm",
            "Stamen",
            "Pistil",
            "Inflorescence",
            "Bract",
            "Glyoxysomes",
            "Plastids"
            };
            int NotFlexNum = Random.Range(0, NotFlexTerms.Length);
            BadTerms = NotFlexTerms[NotFlexNum];
        }
        if (Nowles == "A Virus")
        {
            Debug.Log("Not Viral");
            string[] NotViralTerms =
            {
            "CellWall",
            "Ribosome",
            "Binary Fission",
            "ATP",
            "Bacteria",
            "Archaea",
            "Organelles",
            "Grow",
            "Stimuli",
            "Flagella",
            "Pili"
            };
            int NotViralNum = Random.Range(0, NotViralTerms.Length);
            BadTerms = NotViralTerms[NotViralNum];
        }
        return BadTerms;
    }
}
