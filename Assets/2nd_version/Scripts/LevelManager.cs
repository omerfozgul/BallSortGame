using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private GeneralDataSO generalDataSO;

    [SerializeField] private TextMeshProUGUI levelText;
    private int currentLevelIndex = 0;


    public void createCurrentLevel() {
        createLevel(currentLevelIndex);
        levelText.text = "LEVEL" + (currentLevelIndex + 1);
        currentLevelIndex++;
        PlayerPrefs.SetInt("nextLevel", currentLevelIndex);
    }
    private void createLevel(LevelDataSO levelData) {
        if (levelData == null)
            Debug.Log(null);
        levelGenerator.generateLevel(levelData, generalDataSO.Colors);
    }

    public void createLevel(int levelNum) {
        LevelDataSO levelDataSO = generalDataSO.LevelDataSOArray[levelNum];
        createLevel(levelDataSO);
    }

    public LevelDataSO getCurrentLevelDataSO() {
        LevelDataSO levelDataSO = generalDataSO.LevelDataSOArray[currentLevelIndex];
        return levelDataSO;
    }

    public Stack<BallView>[] getBalls() {
        return levelGenerator.getBalls();
    }
    public List<TubeView> getTubes(){
        return levelGenerator.getTubes();
    }
}
