
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyLoader : MonoBehaviour
{	
	public Kitty myKitty;
    // Start is called before the first frame update
    void Awake(){

    	//Load text from jsonfile into  the string
    	 string myLoadedKitty = ApiHelper.LoadsJsonAsResources("GetKitty/MyKitty/NewKitty.json");
    	 Debug.Log(myLoadedKitty);
    	 //loads value into item
    	 myKitty = JsonUtility.FromJson<Kitty>(myLoadedKitty);

     }

     void Start() {

     }

     void update() {
     	
     }


    
}
