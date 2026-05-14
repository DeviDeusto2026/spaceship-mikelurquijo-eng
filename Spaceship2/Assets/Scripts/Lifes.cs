using UnityEngine;

public class Lifes : MonoBehaviour
{

    private int lives = 3;
    private int spawnBoss = 0;
    public GameObject boss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boss.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
   
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Bullet")) return;
        Destroy(other.gameObject);
        lives--;


        if (lives == 0) {
            Destroy(this.gameObject);
            spawnBoss ++;
            boss.SetActive (true);
        }

       
        

    }

   
}
