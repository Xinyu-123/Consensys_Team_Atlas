
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApiHelper
{
    public static string LoadsJsonAsResources(string path) 
    {	
    	string jsonFilePath = path.Replace(".json", "");
    	TextAsset loadedJsonfile = Resources.Load<TextAsset>(jsonFilePath);
    	return loadedJsonfile.text;
    }

    
}

/*
[Serializable]
public class Status
{ 
    public object cooldown ;
    public int cooldown_index ;
    public bool is_ready ;
    public bool is_gestating ;
}
[Serializable]
public class Purrs
{
    public int count ;
    public bool is_purred ;
}
[Serializable]
public class Watchlist
{
    public int count ;
    public bool is_watchlisted ;
}
[Serializable]
public class Seller
{
    public string address ;
}
[Serializable]
public class Auction
{
    public int? id ;
    public string type ;
    public string start_price ;
    public string end_price ;
    public string start_time ;
    public string end_time ;
    public string current_price ;
    public string duration ;
    public string status ;
    public Seller seller ;
}
[Serializable]
public class Status2
{
    public long cooldown ;
    public int cooldown_index ;
    public bool is_ready ;
    public bool is_gestating ;
}
[Serializable]
public class Owner
{
    public string address ;
}
[Serializable]
public class Matron
{
    public int? id ;
    public string name ;
    public string image_url ;
    public string image_url_cdn ;
    public string image_url_png ;
    public int? generation ;
    public DateTime? created_at ;
    public string color ;
    public bool? is_fancy ;
    public bool? is_exclusive ;
    public string fancy_type ;
    public string language ;
    public Status2 status ;
    public Owner owner ;
}
[Serializable]
public class Status3
{
    public object cooldown ;
    public int cooldown_index ;
    public bool is_ready ;
    public bool is_gestating ;
}
[Serializable]
public class Owner2
{
    public string address ;
}
[Serializable]
public class Sire
{
    public int? id ;
    public string name ;
    public string image_url ;
    public string image_url_cdn ;
    public string image_url_png ;
    public int? generation ;
    public DateTime? created_at ;
    public string color ;
    public bool? is_fancy ;
    public bool? is_exclusive ;
    public string fancy_type ;
    public string language ;
    public Status3 status ;
    public Owner2 owner ;
}
[Serializable]
public class Owner3
{
    public string address ;
}
[Serializable]
public class Kitty
{
    public int id ;
    public string name ;
    public string bio ;
    public string image_url ;
    public string image_url_cdn ;
    public string image_url_png ;
    public string image_path ;
    public int generation ;
    public DateTime created_at ;
    public string color ;
    public bool is_fancy ;
    public bool is_exclusive ;
    public string fancy_type ;
    public string language ;
    public List<object> enhanced_cattributes ;
    public Status status ;
    public Purrs purrs ;
    public Watchlist watchlist ;
    public bool hatched ;
    public bool is_prestige ;
    public object prestige_type ;
    public object prestige_ranking ;
    public object prestige_time_limit ;
    public Auction auction ;
    public Matron matron ;
    public Sire sire ;
    public Owner3 owner ;
}
[Serializable]
public class RootObject
{
    public int limit ;
    public int offset ;
    public List<Kitty> kitties ;
    public int total ;
}
*/
