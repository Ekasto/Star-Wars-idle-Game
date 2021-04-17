using UnityEngine;
using UnityEngine.UI;
public class Ui : MonoBehaviour
{
    public Text coinsText;
    public double coins;
     void Start()
    {
        coins = 100;
        coinsText = GetComponent<Text>();
        coinsText.text = "eugzudt: " + Session.Money.ToString();
    }
         void Update()
        {
            //coinsText.text = "eugzudt: " + coins.ToString();
        }
    
}
