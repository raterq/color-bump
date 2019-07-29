using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObstacle
{
    bool Collided { get; }
    void SetColor(Color color);
    void SetPosition(Vector3 position);
}

public class ObstacleBehaviour : MonoBehaviour, IObstacle
{
    public bool Collided { get; private set; }
    private const float _speed = 3;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()//todo vova kastilio move to ecs loop
    {
        _rigidbody.velocity = Vector3.back * _speed;   
    }

    public void SetColor(Color color)
    {
        GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Character"))
            Collided = true;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Character"))
            Collided = false;
    }

    public void SetPosition(Vector3 position)
    {
        transform.localPosition = position;
    }
}
