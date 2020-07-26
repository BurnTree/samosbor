using UnityEngine;
using UnityEngine.SceneManagement;

public class Room : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("go to room");
        SceneManager.LoadScene("room", LoadSceneMode.Single);
    }
}