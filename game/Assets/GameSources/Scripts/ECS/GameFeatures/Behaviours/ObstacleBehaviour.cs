using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObstacle
{
    bool Collided { get; }
    void SetColor(Color color);
}

public class ObstacleBehaviour : MonoBehaviour, IObstacle
{
    public bool Collided { get; private set; }

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
}
