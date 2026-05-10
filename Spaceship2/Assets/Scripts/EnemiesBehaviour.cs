using UnityEngine;

public class EnemiesBehaviour : MonoBehaviour
{

    public int speed = 3;
    public int sppedZ = 6;
    public float timePassed = 4.0f;
    public float timePassedZ = 2.0f;

    private bool flagTime = true;
    private bool flagZ = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed -= Time.deltaTime;
        timePassedZ -= Time.deltaTime;


        if (flagTime == true) {
            this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;   
        }

        if (flagTime == false)
        {
            this.gameObject.transform.position += Vector3.left * speed * Time.deltaTime;           
        }


        if (flagZ == true)
        {
            this.gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (flagZ == false)
        {
            this.gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
        }



        if (timePassed < 0.0f)
        {
            flagTime = !flagTime;
            timePassed = 4.0f;
        }

        if (timePassedZ < 0.0f)
        {
            flagZ = !flagZ;
            timePassedZ = 2.0f;
        }
    }
}
