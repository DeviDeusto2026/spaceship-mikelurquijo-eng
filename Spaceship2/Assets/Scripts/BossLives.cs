using UnityEngine;
using UnityEngine.SceneManagement;

public class BossLives : MonoBehaviour
{

    private int bossHealthPoints = 12;
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
        if (other.gameObject.layer != LayerMask.NameToLayer("Bullet")) return;
        Destroy(other.gameObject);
        bossHealthPoints--;

        if (bossHealthPoints == 0) {
            SceneManager.LoadScene("WinScene");
        }
    }
}
