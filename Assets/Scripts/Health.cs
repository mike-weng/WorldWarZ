using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    public float health = 100.0f;
    public bool isDead = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DecreaseHealth(float value)
    {
        health -= value;
        print("decrease: " + health);
        if (health <= 0 && !isDead)
        {
            Character character = GetComponent<Character>();
            character.Die();
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.AddNumKills();
            Invoke("DestroyZombie", 5.0f);
            isDead = true;
        }
    }

    void DestroyZombie() {
        Destroy(this.gameObject);
    }

    public void IncreaseHealth(float value)
    {
        health += value;
        print("increase: " + health);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}

