using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("go to floor");
        SceneManager.LoadScene("floor", LoadSceneMode.Single);
    }
}
