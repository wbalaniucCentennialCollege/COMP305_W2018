using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class EnemyHealthData
{
    public float maxHealth;
    public float currentHealth;
    public Slider healthBar;
}

[System.Serializable]
public class EnemyScoreData
{
    public int scoreValue = 10;
    public ScoreController scoreCont;
}


public class EnemyHealth : MonoBehaviour {

    public EnemyHealthData enemyHealthData;
    public EnemyScoreData enemyScoreData;
    /*
    public float maxHealth;
    public float currentHealth;
    public Slider healthBar;
    */

        /*
    public int scoreValue = 10;
    public ScoreController scoreCont;
    */

    // Define scoring

	// Use this for initialization
	void Start () {
        enemyHealthData.currentHealth = enemyHealthData.maxHealth;
	}
	
	public void Damage(float damageAmt)
    {
        enemyHealthData.currentHealth -= damageAmt;
        // currentHealth = currentHealh - damageAmt;
        UpdateHealth();
    }

    void UpdateHealth()
    {
        if(enemyHealthData.currentHealth <= 0)
        {
            Die();
        }

        enemyHealthData.healthBar.value = enemyHealthData.currentHealth / enemyHealthData.maxHealth;
    }

    void Die()
    {
        enemyScoreData.scoreCont.UpdateScore(enemyScoreData.scoreValue);
        Destroy(this.gameObject);
    }
}
