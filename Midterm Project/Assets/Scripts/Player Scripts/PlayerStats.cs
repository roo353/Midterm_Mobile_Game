using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public CharacterData characterData;

    //current stats
    float currentHealth;
    float currentRecovery;
    float currentmoveSpeed;
    float currentMight;
    float currentProjectileSpeed;

    //Xp stats
    [Header("Experience")]
    public int experience = 0;
    public int level = 1;
    public int xpCap;

    [System.Serializable]
    public class LevelRange
    {
        public int startLevel;
        public int endLevel;
        public int xpCapIncrease;
    }

    //I-Frames
    [Header("I-Frames")]
    public float invincibilityDuration;
    float invincibilityTimer;
    bool isInvincible;

    [Header("UI")]
    public Image healthBar;
    public Image xpBar;
    public Text levelText;

    [SerializeField] private AudioSource damageSound;


    public List<LevelRange> levelRanges;

    void Awake()
    {
        currentHealth = characterData.maxHealth;
        currentRecovery = characterData.recovery;
        currentmoveSpeed = characterData.moveSpeed;
        currentMight = characterData.might;
        currentProjectileSpeed = characterData.projectileSpeed;
    }

    void Start()
    {
        xpCap = levelRanges[0].xpCapIncrease;

        UpdateHealthBar();

        UpdateXpBar();
        UpdateLevelText();
    }

    void Update()
    {
        if(invincibilityTimer > 0)
        {
            invincibilityTimer -= Time.deltaTime;
        }
        else if(isInvincible)
        {
            isInvincible = false;
        }
    }

    public void IncreaseXP(int amount)
    {
        experience += amount;

        LevelUpChecker();

        UpdateXpBar();
    }

    void LevelUpChecker()
    {
        if(experience >= xpCap)
        {
            level++;
            experience -= xpCap;

            int xpCapIncrease = 0;
            foreach(LevelRange range in levelRanges)
            {
                if(level >= range.startLevel && level <= range.endLevel)
                {
                    xpCapIncrease = range.xpCapIncrease;
                    break;
                }
            }
            xpCap = xpCapIncrease;

            UpdateLevelText();
        }
    }

    void UpdateXpBar()
    {
        xpBar.fillAmount = (float)experience / xpCap;
    }

    void UpdateLevelText()
    {
        levelText.text ="XP LEVEL: " + level.ToString();
    }

    public void TakeDamage(float dmg)
    {
        if(!isInvincible)
        {
            currentHealth -= dmg;

            invincibilityTimer = invincibilityDuration;
            isInvincible = true;

            if(currentHealth <= 0)
            {
            Kill();
            }
        }
        damageSound.Play();
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHealth / characterData.maxHealth;
    }

    public void Kill()
    {
        Debug.Log("Damage Taken");
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
