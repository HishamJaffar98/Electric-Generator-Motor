using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager
{
    static int currentLevel;
    static int totalLevels = SceneManager.sceneCountInBuildSettings;

    public static IEnumerator LoadNextLevel(float delayTime)
    {
        currentLevel = UpdateLevelIndex();
        yield return new WaitForSecondsRealtime(delayTime);
        SceneManager.LoadScene((currentLevel+1)%totalLevels);
    }

    public static IEnumerator LoadLevel(float delayTime, int level)
    {
        yield return new WaitForSecondsRealtime(delayTime);
        SceneManager.LoadScene(level);
    }
    
    public static IEnumerator LoadPrevLevel(float delayTime)
    {
        currentLevel = UpdateLevelIndex();
        yield return new WaitForSecondsRealtime(delayTime);
        SceneManager.LoadScene(currentLevel - 1);
    }

    public static IEnumerator QuitApplication()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Application.Quit();
    }

    public static int UpdateLevelIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
