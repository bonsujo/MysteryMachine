using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public Slider slider;
    public AudioSource gameOverSfx;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        if (health <= 0)
        {
            gameOverSfx.Play();
            //Debug.Log("Player dead");
            PlayerManager.gameOver = true;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            health = health - 0.1f;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            health = health - 0.5f;
        }
    }
}
