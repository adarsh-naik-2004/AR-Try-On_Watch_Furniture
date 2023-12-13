using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewWatch : MonoBehaviour
{
    public GameObject[] watches;
    private int currentWatch = 0;

    public void nextwatch()
    {
        for (int i = 0; i < watches.Length; i++)
        {
            watches[i].gameObject.SetActive(false);
        }
        currentWatch++;
        if (currentWatch == watches.Length)
        {
            currentWatch = 0;
        }
        watches[currentWatch].gameObject.SetActive(true);
    }

    public void backwatch()
    {
        for (int i = 0; i < watches.Length; i++)
        {
            watches[i].gameObject.SetActive(false);
        }
        currentWatch--;
        if (currentWatch == -1)
        {
            currentWatch = watches.Length - 1;
        }
        watches[currentWatch].gameObject.SetActive(true);
    }

    public void BackToScene()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
