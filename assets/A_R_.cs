using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A_R_ : MonoBehaviour
{
    public void furniture()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void watches()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void back()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
