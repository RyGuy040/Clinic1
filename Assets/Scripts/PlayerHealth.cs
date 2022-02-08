using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public float hitPoints = 5.0f;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI gameoverText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + hitPoints;

        if(hitPoints <= 0)
        {
            gameoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            hitPoints -= 1.0f;
            Debug.Log("this feature is working right");
        }
    }
}
