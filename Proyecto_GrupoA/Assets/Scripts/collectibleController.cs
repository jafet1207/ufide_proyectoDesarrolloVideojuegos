using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collectibleController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textCoins;

    [SerializeField]
    TextMeshProUGUI resultCoins;

    [SerializeField]
    int quantCoins = 0;

    static int totalCoins = 0;

    void Start()
    {
        textCoins.text = "0";
        textCoins.text = $"Monedas: 0/{quantCoins}";
    }

    void Update()
    {
        textCoins.text = totalCoins.ToString();
        resultCoins.text = $"Monedas: {totalCoins}/{quantCoins}";
    }

    public static void addCoin()
    {
        totalCoins++;
    }


}