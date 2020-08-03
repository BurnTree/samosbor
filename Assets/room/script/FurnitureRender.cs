using UnityEngine;

public class FurnitureRender : MonoBehaviour
{
    public GameObject furnitures;
    private BoxCollider2D _collider2D;

    void Start()
    {
        _collider2D = GetComponent<BoxCollider2D>();
        Instantiate(furnitures, new Vector2(transform.position.x, _collider2D.bounds.min.y),
            Quaternion.identity);
    }
}