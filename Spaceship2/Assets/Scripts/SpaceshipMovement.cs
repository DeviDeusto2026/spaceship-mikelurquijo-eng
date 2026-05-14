using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{

    public int speed;
    public int rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.L)) { 
            this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.J)) { 
            this.transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
    }
}