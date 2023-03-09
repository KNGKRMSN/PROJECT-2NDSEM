using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    [SerializeField] private Image healthbarsprite;

    // Update is called once per frame
    public void UpdateHealthBar(float maxhealth, float health)
    {
        healthbarsprite.fillAmount = health / maxhealth;
    }
    void Update()
    {
    }
}
