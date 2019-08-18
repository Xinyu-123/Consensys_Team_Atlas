/*
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Core.Signing.Crypto;
using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplyGame.Ethereum
{
    [FunctionOutput]

    // changed the function name to transferFrom
    public class TransferFrom
    {

        [Parameter("address", "_from", 1)]
        public string AddressFrom { get; set; }
        [Parameter("address", "_to", 1)]
        public string AddressTo { get; set; }
        [Parameter("uint256", "_value", 2)]
        public int Amount { get; set; }
    }
    public class GameTokenService
    {

        public static string DEFAULT_MORDEN = "goerli.infura.io/v3/7238211010344719ad14a89db874158c";

        //private key from your wallet
        public static string PRIVATE_KEY = "9a8b378afd4cc61febc4b726f34d50973b1ccec6aaf649ca83e9382f027d53dc";

        //this is Vaid's abi

        private string abi = "[
	{
		"constant": true,
		"inputs": [],
		"name": "totalSupply",
		"outputs": [
			{
				"name": "",
				"type": "uint256"

            }
		],
		"payable": false,
		"stateMutability": "view",
		"type": "function"
	},
	{
		"constant": true,
		"inputs": [
			{
				"name": "_owner",
				"type": "address"
			}
		],
		"name": "balanceOf",
		"outputs": [
			{
				"name": "",
				"type": "uint256"
			}
		],
		"payable": false,
		"stateMutability": "view",
		"type": "function"
	},
	{
		"constant": false,
		"inputs": [
			{
				"name": "_to",
				"type": "address"
			},
			{
				"name": "_value",
				"type": "uint256"
			}
		],
		"name": "transfer",
		"outputs": [
			{
				"name": "",
				"type": "bool"
			}
		],
		"payable": false,
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"anonymous": false,
		"inputs": [
			{
				"indexed": true,
				"name": "from",
				"type": "address"
			},
			{
				"indexed": true,
				"name": "to",
				"type": "address"
			},
			{
				"indexed": false,
				"name": "value",
				"type": "uint256"
			}
		],
		"name": "Transfer",
		"type": "event"
	}
]";

        //contract address from Vaid's contract

        private string contractAddress = "0xc57fd1a0c77383c6e4069ae333e8547f9a95bf88";



public static GameTokenService Current { get; private set; }

public static void Init(string privateKey, string url)

{

    Current = new GameTokenService(privateKey, url);

}

public string PrivateKey { get; private set; }

public string Url { get; private set; }

private Web3 web3;

private string address;

private Contract contract;

private GameTokenService(string privateKey, string url)

{

    this.PrivateKey = privateKey;

    this.Url = url;

    this.web3 = new Web3(url);

    this.address = "0x" + EthECKey.GetPublicAddress(privateKey); //could do checksum

    this.contract = web3.Eth.GetContract(abi, contractAddress);

}

public async Task<string> SendTokenstoPlayer(int CurrentPoints)

{

    TokensToSend = CurrentPoints / 7 //conversion ratio for points to tokens, should add mod to round points

            {

        var txCount = await web3.Eth.Transactions.GetTransactionCount.SendRequestAsync(address).ConfigureAwait(false);

        var function = contract.GetFunction("transferFrom");

        //I'm confused about this line - I don't understand why the function seems to be calling a function....

        // I would expect data to be more like

        // contracts.methods.function.call({transerFrom, transferTo, Amount}, function(error, result))

        var data = function.GetData(score);

        var encoded = web3.OfflineTransactionSigning.SignTransaction(PrivateKey, contractAddress, 0,

          txCount.Value, 1000000000000L, 900000, data);

        return await web3.Eth.Transactions.SendRawTransaction.SendRequestAsync(encoded).ConfigureAwait(false);

    }

    return null;

}

    }
    */