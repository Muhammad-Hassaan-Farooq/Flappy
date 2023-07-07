using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Logic : MonoBehaviour
{





    private void Start()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
