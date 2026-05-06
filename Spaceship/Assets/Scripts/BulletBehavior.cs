using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    public float lifeTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime < 0) { 
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
