using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hunderSlider;
    public int amountToBeFed;
    public int currentFedAmount = 0;

    // private GameManger gameManager;


    // Start is called before the first frame update
    void Start()
    {
        hunderSlider.maxValue = amountToBeFed;
        hunderSlider.value = 0;
        hunderSlider.fillRect.gameObject.SetActive(false);

        // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hunderSlider.fillRect.gameObject.SetActive(true);
        hunderSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            // gameManager.AddScore(amount);
            Destroy(gameObject, 0.1f);
        }
    }
}
