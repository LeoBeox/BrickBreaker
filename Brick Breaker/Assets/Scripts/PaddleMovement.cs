using Unity.VisualScripting;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    [Range(1.0f, 10.0f)]

    public float Speed = 7f;

    [SerializeField] public KeyCode _rightDirection;
    [SerializeField] public KeyCode _leftDirection;

    private float _direction;

    private Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {

        _rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        _rb.linearVelocity = _direction * new Vector2(Speed, 0.0f);
    }


    // Update is called once per frame
    void Update()
    {

        _direction = 0.0f;

        if (Input.GetKey(_rightDirection))
            _direction += 1.0f;
        if (Input.GetKey(_leftDirection))
            _direction -= 1.0f;


    }


}
