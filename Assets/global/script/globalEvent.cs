using UnityEngine;

public class globalEvent : MonoBehaviour
{
    public GameObject[] floors;
    private const float fHeight = 9f;
    private const float fWidth = 16f;

    private const float defaultSizeX = 4f;
    private const float defaultSizeY = 1f;

    private void Awake()
    {
        const float leftBorder = (-1) * fWidth / 2;
        const float rightBorder = fWidth / 2;
        const float topBorder = (-1) * fHeight / 2;
        const float bottomBorder = fHeight / 2;

        for (var y = topBorder; y + defaultSizeY <= bottomBorder; y += defaultSizeY)
        for (var x = leftBorder; x + defaultSizeX <= rightBorder; x += defaultSizeX)
            Instantiate(floors[0], new Vector3(x + defaultSizeX / 2, y + defaultSizeY / 2, 0), Quaternion.identity);
    }
}
