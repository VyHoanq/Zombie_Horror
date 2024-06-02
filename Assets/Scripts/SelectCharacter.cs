using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    public GameObject selectCharater;
    public GameObject mainMenu;
    public void OnBackButton()
    {
        selectCharater.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void OnCharacter1()
    {
        SceneManager.LoadScene("ZombieLand");
    }
    public void OnCharacter2()
    {
        SceneManager.LoadScene("ZombieLand1");
    }
    public void OnCharacter3()
    {
        SceneManager.LoadScene("ZombieLand2");
    }
}
