using UnityEngine;

public class GetPointTwo : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            Invoke("CreateBall", 1f);
        }
    }

    void CreateBall()
    {
        Instantiate(ball, Vector2.zero, Quaternion.identity);
    }
}
