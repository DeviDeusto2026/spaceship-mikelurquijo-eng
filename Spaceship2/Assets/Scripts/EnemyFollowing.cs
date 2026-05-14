using UnityEngine;

public class EnemyFollowing : MonoBehaviour
{

    public GameObject player;
    public int speed;

    public float distance;
    private float distance2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        distance2 = Vector3.Distance(this.gameObject.transform.position, player.transform.position);
        if (distance2 >= distance)
        {

            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, player.transform.position, speed * Time.deltaTime);
        }
      
    }
}
