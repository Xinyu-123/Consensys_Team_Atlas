using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.UnityClient;

public class Netherium : MonoBehaviour
{
    public Text uiTextEtherBalance;

    public string networkUrl = "https://rinkeby.infura.io";

    //players wallet
    public string playerEthereumAccount = "0xF2dC4274c39f35ac21012Ed99ac6FbA84d348118";
    public string playerEthereumAccountPK = "9a8b378afd4cc61febc4b726f34d50973b1ccec6aaf649ca83e9382f027d53dc";

    //atlas wallet
    private string contractOwnerAddress = "0x87f9496D05F9f0E11A07EDDf4E00D8B4E2e189d0";
    private string contractOwnerPK = "384DFDDE13AA9527B74D04A32EBC1796783446ACCA38F4A39394F29CD34DCAED";

    private IEnumerator getAccountBalanceCoroutine;
    private string balanceG;

    private static Netherium instance;

    void Start()
    {
        // Prepare our coroutines            
        getAccountBalanceCoroutine = GetAccountBalanceCoroutine();
    }

    public void GetAccountBalance()
    {
        // Get address balance 
        StopCoroutine(getAccountBalanceCoroutine);
        getAccountBalanceCoroutine = GetAccountBalanceCoroutine();
        StartCoroutine(getAccountBalanceCoroutine);


        uiTextEtherBalance.text = balanceG;
    }

    // Check Ether balance of the player account
    public IEnumerator GetAccountBalanceCoroutine()
    {
        var getBalanceRequest = new EthGetBalanceUnityRequest(networkUrl);
        // Send balance request with player's account, asking for balance in latest block
        yield return getBalanceRequest.SendRequest(playerEthereumAccount, Nethereum.RPC.Eth.DTOs.BlockParameter.CreateLatest());

        if (getBalanceRequest.Exception == null)
        {
            var balance = getBalanceRequest.Result.Value;
            // Convert the balance from wei to ether and round to 8 decimals for display
            balanceG = Nethereum.Util.UnitConversion.Convert.FromWei(balance, 18).ToString("n8");
        }
    }

}