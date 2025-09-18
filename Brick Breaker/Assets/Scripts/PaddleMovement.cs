using Unity.VisualScripting;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    public float Speed = 7f;

    public KeyCode RightDirection;
    public KeyCode LeftDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        float movement = 0.0f;

        if (Input.GetKey(RightDirection) && transform.position.x <= 6.5)
        {
            movement += Speed;
        }

        if (Input.GetKey(LeftDirection) && transform.position.x >= -6.5)
        {
            movement -= Speed;
        }

        transform.position += new Vector3(movement * Time.deltaTime, 0.0f, 0.0f);

        // float Clamped_X = Mathf.Clamp(transform.position.x, Min_X, Max_X);

        // transform.position += new Vector3(Clamped_X, transform.position.y, transform.position.z);

    }


}
