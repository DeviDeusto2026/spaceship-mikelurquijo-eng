using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    public GameObject bullet;
    public float lifeTime = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(bullet, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(bullet);
    }
}
