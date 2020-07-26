using UnityEngine;
using UnityEngine.SceneManagement;

public class backButtonFloor : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("go to global");
        SceneManager.LoadScene("global", LoadSceneMode.Single);
    }
}