using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
  private HealthSystem healthSystem;

  public Sprite[] healthSprites;
  private SpriteRenderer spriteR;
  

  public void Setup(HealthSystem healthSystem){
    this.healthSystem = healthSystem;

    spriteR = gameObject.GetComponent<SpriteRenderer>();
    healthSystem.OnHealthChanged += HealthSystem_OnHealthChanged;
  }

  private void HealthSystem_OnHealthChanged(object sender, System.EventArgs e)
  {
    
    if (healthSystem.GetHealth() != 0)
    {
      spriteR.sprite = healthSprites[healthSystem.GetHealth()-1];
    }
    else
    {
      print("aí o cara tá morto");
    }
    
  }

}
