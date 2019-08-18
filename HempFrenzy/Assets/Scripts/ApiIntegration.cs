using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;



public class ApiIntegration : MonoBehaviour
{

  private const string URL = "https://public.api.cryptokitties.co/v1/kitties?tricks_by_dapp_name=KittiesforFuture";
   private const string API_KEY_TOKEN = "VNlIue9ZTDho2IkIAxB6DFJP41XwB3MUi2R9Ev0QvRk";
 
   public void Request(){

      //Form helps give out specific into screen
      WWWForm form = new WWWForm();
      //Takes existing header for api_token

      Dictionary <string, string> headers = form.headers;
      headers["x-api-token"] = API_KEY_TOKEN;

   
      WWW request = new WWW(URL,null,headers);
      print("My request URL: " + request.url);

      StartCoroutine(OnResponse(request));
   }

   private IEnumerator OnResponse(WWW res){

      yield return res;
      print ("Response" + res.text);
   }

}
      
   




