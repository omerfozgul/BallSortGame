using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject tubes;
    [SerializeField] private GameObject levelText;
    public void level1(){
        mainMenu.SetActive(false);
        tubes.SetActive(true);
        levelText.SetActive(true);
    }

    public void nextLevel(){
        gameManager.startNextLevel();
    }
}
