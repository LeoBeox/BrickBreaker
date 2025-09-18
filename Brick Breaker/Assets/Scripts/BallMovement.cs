using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float Speed = 3.0f;

    private int _xDirection;
    private int _yDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _xDirection = Random.value >= 0.5f ? 1 : -1;
        _yDirection = Random.value >= 0.5f ? 1 : -1;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(Speed * _xDirection
        , Speed * _yDirection, 0.0f) * Time.deltaTime;
        
    }
}
