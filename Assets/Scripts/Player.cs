using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI levelText;
    public Material bgLevel1;
    public Material bgLevel2;
    public Material bgLevel3;
    public float speed;
    private int hp = 3;
    private int level = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        SetHPCount();
        SetLevel();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speed*Time.deltaTime);   
    }

    private void SetHPCount() {
        hpText.text = "HP: " + hp.ToString();
    }

    private void HandleGameOver()
    {
        speed = 0;
        Debug.Log("Game Over");
    }

    private void HandleCollision()
    {
        Debug.Log("Hit!!");
        hp -= 1;
        Debug.Log("HP" + hp.ToString());
        SetHPCount();
        if(hp == 0) {
            // HandleGameOver();
        }
    }

    private void SetLevel()
    {
        levelText.text = "Level: " + level.ToString();
        if(level == 1) {
            RenderSettings.skybox = bgLevel1;
        } else if (level == 2) {
            RenderSettings.skybox = bgLevel2;
        } else {
            RenderSettings.skybox = bgLevel3;
        }
    }

    private void HandleLevelUp()
    {
        level += 1;
        Debug.Log("Leveled Up!");
        SetLevel();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Obstacle")) {
            HandleCollision();
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Level")) {
            HandleLevelUp();
        }
    }
}
