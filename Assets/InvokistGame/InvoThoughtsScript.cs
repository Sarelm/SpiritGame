using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvoThoughtsScript : MonoBehaviour
{
    public static InvoThoughtsScript Instance { get; private set; }
    public static TextMeshProUGUI InvoMasterTerm;
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
        var Term = InvoTerm();
        Nowles = Term;
        InvoMasterTerm = gameObject.GetComponent<TextMeshProUGUI>();
        InvoMasterTerm.text = "Terms associated with: " + Term;
    }
    public static string InvoTerm()
    {
        string[] InvoTerms =
        {
            "Subatomic Particles",
            "Noble Gases"
        };
        int InvoTermNum = Random.Range(0, InvoTerms.Length);
        string PickInvoTerm = InvoTerms[InvoTermNum];
        return PickInvoTerm;
    }
    public static string GetTerms()
    {
        string Terms = "";
        if (Nowles == "Subatomic Particles")
        {
            Debug.Log("Too small");
            string[] TinyTerms =
            {
            "Neutron",
            "Proton",
            "Electron",
            "Photon",
            "Meson",
            "Muon",
            "Composite Particle",
            "Elementary Particle",
            "Tau",
            "Quark"
            };
            int TinyTermsNum = Random.Range(0, TinyTerms.Length);
            Terms = TinyTerms[TinyTermsNum];
        }
        if (Nowles == "Noble Gases")
        {
            Debug.Log("Gassy");
            string[] CrystalTerms =
            {
            "Neon",
            "Xenon",
            "Helium",
            "Argon",
            "Krypton",
            "Radon",
            "Oganesson"
            };
            int CrystalTermsNum = Random.Range(0, CrystalTerms.Length);
            Terms = CrystalTerms[CrystalTermsNum];
        }
        return Terms;
    }
    public static string GetBadTerms()
    {
        string BadTerms = "";
        if (Nowles == "Subatomic Particles")
        {
            Debug.Log("Bit Bigger");
            string[] NotSmallTerms =
            {
            "Argon",
            "Neon",
            "Xenon",
            "Radon",
            "Oganesson",
            "Bismuth",
            "Carbon",
            "Boron",
            "Metalloid",
            "Halogen"
            };
            int NotSmallNum = Random.Range(0, NotSmallTerms.Length);
            BadTerms = NotSmallTerms[NotSmallNum];
        }
        if (Nowles == "Noble Gases")
        {
            Debug.Log("Not Noble");
            string[] NotCryTerms =
            {
            "Hydrogen",
            "Oxygen",
            "Nitrogen",
            "Boron",
            "Lithium",
            "Phosphorus",
            "Fluorine",
            "Chlorine"
            };
            int NotCryTNum = Random.Range(0, NotCryTerms.Length);
            BadTerms = NotCryTerms[NotCryTNum];
        }
        return BadTerms;
    }
}
