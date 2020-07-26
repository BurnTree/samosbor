using UnityEngine;
using UnityEngine.SceneManagement;

public class floorEventToGlobal : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("go to floor");
        SceneManager.LoadScene("floor", LoadSceneMode.Single);
    }
}