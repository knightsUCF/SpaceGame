using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Menu : MonoBehaviour
{
  
    public GameObject menu;
    public GameObject proceduralPanel;
    public GameObject audioSource;




    Game game;



    private void Start()
    {
        game = FindObjectOfType<Game>();
    }




    public void OnMenuClick()
    {
        Debug.Log("Clicked on the menu");
        audioSource.GetComponent<AudioSource>().Play();
        menu.SetActive(false);
        proceduralPanel.SetActive(true);
    }



    public void OnGenerateGalaxyClick()
    {
        Debug.Log("Generating galaxy");
        audioSource.GetComponent<AudioSource>().Play();
        proceduralPanel.SetActive(false);
        game.GameStart();
    }
    
}
