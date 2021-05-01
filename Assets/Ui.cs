using UnityEngine;
using UnityEngine.UI;

// added to use strings
using System.Collections;


using IdleEngine;
using IdleEngine.Sessions;

public class Ui : MonoBehaviour
{
    public Text coinsText;
    public double coins;

    public IdleEngineClass idleEngineClass;

     void Start()
    {
        coins = 100;
        coinsText = GetComponent<Text>();

        idleEngineClass = FindObjectOfType<IdleEngineClass>();

    }
    void Update()
    {
        string moneyLabelString = "money = ";
        string moneyCountString = idleEngineClass.idleSession.Money.ToString();
        string combinedMoneyString = string.Concat(moneyLabelString, moneyCountString);

        coinsText.text = combinedMoneyString;

    }
    
}
