using UnityEngine;

public class RoomRender : MonoBehaviour
{
    public GameObject room;
    void Start()
    {
        Instantiate(room, new Vector2(0f, 0f), Quaternion.identity);
    }
}
