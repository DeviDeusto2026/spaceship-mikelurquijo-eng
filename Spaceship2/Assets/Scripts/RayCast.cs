using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bullet;
    public float force;

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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Object.Instantiate(bullet, transform.position + Vector3.forward, q);
            newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);
        }
    }

    private void FixedUpdate()
    {
        int layerMask = 1 << 10;
        layerMask = ~layerMask;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(this.transform.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(this.transform.forward) * hit.distance, Color.red);
            //Debug.Log("Did hit" + hit.collider.gameObject.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //Debug.Log("not hitting");
        }

    }

}
