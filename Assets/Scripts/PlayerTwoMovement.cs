using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // arrows up and down to move
        if (Input.GetKey(KeyCode.W) &&  transform.position.y < 4)
        {
            transform.Translate(Vector3.up * (Time.deltaTime * 10));
        }

        if (Input.GetKey(KeyCode.S)  &&  transform.position.y > -4)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * 10));
        }
    }
}
