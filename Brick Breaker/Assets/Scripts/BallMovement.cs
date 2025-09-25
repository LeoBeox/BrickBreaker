using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] public float _launchForce = 5.0f;

    private int _xDirection;
    private int _yDirection;

    [SerializeField] private float _paddleInfluence = 0.5f;

    private Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _rb = GetComponent<Rigidbody2D>();

        UnityEngine.Vector2 direction = new UnityEngine.Vector2(
            GetNonZeroRandomFloat(),
            GetNonZeroRandomFloat()
        ).normalized;

        _rb.AddForce(direction * _launchForce, ForceMode2D.Impulse);

    }


    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Paddle"))
        {
            if (Mathf.Approximately(other.rigidbody.linearVelocity.y, 0.0f))
            {
                UnityEngine.Vector2 direction = _rb.linearVelocity * (1 - _paddleInfluence)
                + other.rigidbody.linearVelocity * _paddleInfluence;

                _rb.linearVelocity = _rb.linearVelocity.magnitude * direction.normalized;
            
            }
        }


    }


    float GetNonZeroRandomFloat(float min = -1.0f, float max = 1.0f)
    {

        float num;

        do
        {
            num = Random.Range(min, max);

        } while (Mathf.Approximately(num, 0.0f));

        return num;
    }



    // Update is called once per frame
    void Update()
    {

        
    }
}
