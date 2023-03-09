using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingHit : MonoBehaviour
{

    public float hitpoints;
    public float maxhitpoints = 5;

    [SerializeField] private HealthBarBehaviour healthbar;
    // Start is called before the first frame update
    void Start()
    {
        hitpoints = maxhitpoints;
        healthbar.UpdateHealthBar(maxhitpoints, hitpoints); 
    }

    // Update is called once per frame
    public void TakeHits(float damage)
    {
        hitpoints -= damage;
        healthbar.UpdateHealthBar(maxhitpoints, hitpoints);

        if (hitpoints <= 0)
            Destroy(gameObject);
    }
}
