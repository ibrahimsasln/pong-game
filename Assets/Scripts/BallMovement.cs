using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private float x;
    private float y;
    void Start()
    {
        float x = Random.value > 0.5f ? 1f : -1f;
        float y = Random.Range(-0.5f, 0.5f);
        Vector2 direction = new Vector2(x,y).normalized;
        GetComponent<Rigidbody2D>().linearVelocity = direction * speed;
    }
    
}
