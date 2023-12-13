using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changing_chair : MonoBehaviour
{
    public GameObject[] chairs;
    private int currentchair = 0;

    public void nextchair()
    {
        for (int i = 0; i < chairs.Length; i++)
        {
            chairs[i].gameObject.SetActive(false);
        }
        currentchair++;
        if (currentchair == chairs.Length)
        {
            currentchair = 0;
        }
        chairs[currentchair].gameObject.SetActive(true);
    }

    public void backchair()
    {
        for (int i = 0; i < chairs.Length; i++)
        {
            chairs[i].gameObject.SetActive(false);
        }
        currentchair--;
        if (currentchair == -1)
        {
            currentchair = chairs.Length - 1;
        }
        chairs[currentchair].gameObject.SetActive(true);
    }

    public void Dani()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
