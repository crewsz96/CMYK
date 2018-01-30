using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {

    private GameObject player;
    private int currLevel = 1;
    private int lastLevel = 1;
    private GameObject[] cyanPlatforms;
    private GameObject[] magentaPlatforms;
    private GameObject[] yellowPlatforms;

    private void Start() {

        cyanPlatforms = GameObject.FindGameObjectsWithTag("Cyan Platform");
        magentaPlatforms = GameObject.FindGameObjectsWithTag("Magenta Platform");
        yellowPlatforms= GameObject.FindGameObjectsWithTag("Yellow Platform");

        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        ChangeColor();

        if (player == null)
            LoadLevel();
    }

    private void ChangeColor()
    {
   



    }

    public void ColorCyan()
    {
        for (int i = 0; i < cyanPlatforms.Length; i++)
        {
            // Set Player to Cyan Sprite
            // Set Set Cyan Platforms to Cyan
            // Set all other Platforms to transparent?
        }
    }

    public void M()
    {

    }

    public void Y()
    {

    }

    public void K()
    {

    }

    public void LoadLevel()
    {
       if (currLevel <= lastLevel)
            SceneManager.LoadScene("Level" + currLevel);
    }
}
