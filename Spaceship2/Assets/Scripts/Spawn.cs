using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;

    //public int rows = 2;
    public int distance = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Vector3 position = new Vector3(enemy.transform.position.x + distance, enemy.transform.position.y, enemy.transform.position.z); 
        Vector3 position2 = new Vector3(enemy.transform.position.x - distance, enemy.transform.position.y, enemy.transform.position.z);
        Instantiate(enemy, position, Quaternion.identity); 
        Instantiate(enemy, position2, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
