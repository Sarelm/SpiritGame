using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BaseMenu : MonoBehaviour
{
    public void LoadPickSpirit()
    {
        SceneManager.LoadScene("PickSpirit");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void LoadInventory()
    {
        SceneManager.LoadScene("Inventory");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public GameObject Options;
    public GameObject Credits;
    public GameObject Inventory;
    public GameObject EditRoom;
    public GameObject SummonButton;
    public GameObject QuitButton;
    public bool isEnabled = true;
    public Image CameraIcon;
    public Sprite CameraMode;
    public Sprite Initials;
    public void CameraModeClicked()
    {
        isEnabled = !isEnabled;
        QuitButton.SetActive(isEnabled);
        SummonButton.SetActive(isEnabled);
        EditRoom.SetActive(isEnabled);
        Inventory.SetActive(isEnabled);
        Credits.SetActive(isEnabled);
        Options.SetActive(isEnabled);
        if(isEnabled == true)
        {
            CameraIcon.sprite = CameraMode;
        }
        else
        {
            CameraIcon.sprite = Initials;
        }
    }
}
public class Quitmanager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}