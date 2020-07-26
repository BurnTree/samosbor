using UnityEngine;

public class FloorEvent : MonoBehaviour
{
    public GameObject[] rooms;
    private const float fHeight = 9f;
    private const float fWidth = 16f;

    private const float defaultSizeX = 2.50f;
    private const float defaultSizeY = 0.70f;

    private void Awake()
    {
        const float leftBorder = (-1) * fWidth / 2;
        const float rightBorder = fWidth / 2;
        const float topBorder = (-1) * fHeight / 2;
        const float bottomBorder = fHeight / 2;

        for (var y = topBorder; y + defaultSizeY <= bottomBorder; y += defaultSizeY)
        for (var x = leftBorder; x + defaultSizeX <= rightBorder; x += defaultSizeX)
            Instantiate(rooms[0], new Vector3(x + defaultSizeX / 2, y + defaultSizeY / 2, 0), Quaternion.identity);
    }
}