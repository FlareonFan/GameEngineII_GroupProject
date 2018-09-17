using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;//for the Info switchin;

public class MainMenuScript : MonoBehaviour {

    public Text StoryTxt, InfoTxt, CreditsTxt;



    // Use this for initialization
    void Start() {
        InfoTxt.enabled = false;
        StoryTxt.enabled = false;
        CreditsTxt.enabled = false;
    }
    
    public void PlayGame() {//play the first level, after menu. Scene wise
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadGame() { }//to load 'saved' save state

    public void OptionsMenu() { }//todo, pop up somethinng
    public void GoBack() { }//todo, pop up somethinng

    public void Credits() {
        CreditsTxt.enabled = true;
        InfoTxt.enabled = false;
        StoryTxt.enabled = false;
    }//switch text, or load a sep. page

    //begin switching between Lorem Ibsum
    public void Info() {
        InfoTxt.enabled = true;
        StoryTxt.enabled = false;
        CreditsTxt.enabled = false;
    }
    public void Story() {
        StoryTxt.enabled = true;
        InfoTxt.enabled = false;
        CreditsTxt.enabled = false;
    }

    public void QuitGame() {
        Debug.Log("Game has closed");
        Application.Quit();
    }
}