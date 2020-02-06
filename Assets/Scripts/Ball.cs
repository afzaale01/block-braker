using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;
    private bool hasStarted;
    private Vector3 paddleToBallVector;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
            if (Input.GetMouseButton(0))
            {
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f,10f);
            }
        }
    }
}
