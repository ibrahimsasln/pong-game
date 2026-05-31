using TMPro;
using UnityEngine;

public class GetPointTwo : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject text;
    int score = 0;
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
            score++;
            text.GetComponent<TextMeshProUGUI>().text = score.ToString();
            Invoke("CreateBall", 1f);
        }
    }

    void CreateBall()
    {
        Instantiate(ball, Vector2.zero, Quaternion.identity);
    }
}
