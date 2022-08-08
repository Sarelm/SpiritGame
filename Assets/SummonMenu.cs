using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SummonMenu : MonoBehaviour
{
    public void BackFromSummon()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public GameObject EcoPlay;
    public GameObject NecroPlay;
    public GameObject ChronoPlay;
    public GameObject InvoPlay;
    public GameObject MakeYourPick;
    public bool isEnabled = false;

    public void EcoClicked()
    {
        isEnabled = !isEnabled;
        EcoPlay.SetActive(isEnabled);
        if (isEnabled == false)
            ChronoPlay.SetActive(false);
            InvoPlay.SetActive(false);
            EcoPlay.SetActive(true);
            NecroPlay.SetActive(false);
            MakeYourPick.SetActive(false);
    }
    public void ChronoClicked()
    {
        isEnabled = !isEnabled;
        ChronoPlay.SetActive(isEnabled);
        if (isEnabled == false)
            ChronoPlay.SetActive(true);
            InvoPlay.SetActive(false);
            EcoPlay.SetActive(false);
            NecroPlay.SetActive(false);
            MakeYourPick.SetActive(false);
    }
    public void InvoClicked()
    {
        isEnabled = !isEnabled;
        InvoPlay.SetActive(isEnabled);
        if (isEnabled == false)
            InvoPlay.SetActive(true);
            EcoPlay.SetActive(false);
            NecroPlay.SetActive(false);
            ChronoPlay.SetActive(false);
            MakeYourPick.SetActive(false);
    }
    public void NecroClicked()
    {
        isEnabled = !isEnabled;
        NecroPlay.SetActive(isEnabled);
        if (isEnabled == false)
            InvoPlay.SetActive(false);
            EcoPlay.SetActive(false);
            NecroPlay.SetActive(true);
            ChronoPlay.SetActive(false);
            MakeYourPick.SetActive(false);
    }
    public void LoadEcoGame()
    {
        SceneManager.LoadScene("EcoGame");
    }
    public void LoadInvoGame()
    {
        SceneManager.LoadScene("InvoGame");
    }
    public void LoadChronoGame()
    {
        SceneManager.LoadScene("ChronoGame");
    }
    public void LoadNecroGame()
    {
        SceneManager.LoadScene("NecroGame");
    }
}