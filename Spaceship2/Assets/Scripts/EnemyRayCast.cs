using UnityEngine;

public class EnemyRayCast : MonoBehaviour
{

    public GameObject enemyBullet;
    public float force;
    public float spawnTime = 3.0f;

    private bool flag = true;
    private Quaternion q;
    private RaycastHit hit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        q = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0) {
            GameObject newBullet = Object.Instantiate(enemyBullet, transform.position + Vector3.forward, q);
            newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);
            flag = false;
        }

        if (flag == false) {
            flag = !flag;
            spawnTime = 3.0f;
        }
    }

    private void FixedUpdate()
    {
        int layerMask = 1 << 10;
        layerMask = ~layerMask;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("Did hit" + hit.collider.gameObject.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("not hitting");
        }

    }
}
