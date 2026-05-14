using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{



    private int life = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.layer == LayerMask.NameToLayer("EnemyBullet"))
        {
            Destroy(other.gameObject);
            life = 0;
        }


        if (life == 0)
        {
            //Destroy(this.gameObject);
            SceneManager.LoadScene("LoseScene");
        }
    }
}
