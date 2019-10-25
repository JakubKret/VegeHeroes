using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caprices : MonoBehaviour {

    public bool cheeseCaprice;
    [SerializeField] GameObject cheeseGameObject;

     public bool garlicCaprice ;
    [SerializeField] GameObject garlicGameObject;

    public bool milkCaprice ;
    [SerializeField] GameObject milkGameObject;

     public bool flourCaprice ;
    [SerializeField] GameObject flourGameObject;

    public bool mushroomsCaprice ;
    [SerializeField] GameObject mushroomsGameObject;

    public bool peasCaprice ;
    [SerializeField] GameObject peasGameObject;

    public bool eggCaprice ;
    [SerializeField] GameObject eggGameObject;

    public bool pastaCaprice ;
    [SerializeField] GameObject pastaGameObject;

    public bool butterCaprice ;
    [SerializeField] GameObject butterGameObject;
    
    [SerializeField] GameObject prepTimeSlide;
    [SerializeField] GameObject servesSlide;

    public int prepTimeCaprice;
    public int servesCaprice;

    void OnAwake()
    {
        SaveSystem.LoadCaprices();
    }
    // Use this for initialization
    void Start () {
        cheeseCaprice = SaveSystem.LoadCaprices().cheeseCaprice;
        garlicCaprice = SaveSystem.LoadCaprices().garlicCaprice;
        milkCaprice = SaveSystem.LoadCaprices().milkCaprice;
        flourCaprice = SaveSystem.LoadCaprices().flourCaprice;
        mushroomsCaprice = SaveSystem.LoadCaprices().mushroomsCaprice;
        peasCaprice = SaveSystem.LoadCaprices().peasCaprice;
        eggCaprice = SaveSystem.LoadCaprices().eggCaprice;
        pastaCaprice = SaveSystem.LoadCaprices().pastaCaprice;
        butterCaprice = SaveSystem.LoadCaprices().butterCaprice;
        prepTimeCaprice = SaveSystem.LoadCaprices().prepTimeCaprice;
        servesCaprice = SaveSystem.LoadCaprices().servesCaprice;
        if (cheeseCaprice == true)
        {
            cheeseGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            cheeseGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (garlicCaprice == true)
        {
            garlicGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            garlicGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (milkCaprice == true)
        {
            milkGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            milkGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (flourCaprice == true)
        {
            flourGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            flourGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (mushroomsCaprice == true)
        {
            mushroomsGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            mushroomsGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (peasCaprice == true)
        {
            peasGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            peasGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (eggCaprice == true)
        {
            eggGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            eggGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (pastaCaprice == true)
        {
            pastaGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            pastaGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        if (butterCaprice == true)
        {
            butterGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        }
        else
        {
            butterGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
        }
        prepTimeSlide.GetComponent<Slider>().value = SaveSystem.LoadCaprices().prepTimeCaprice;
        servesSlide.GetComponent<Slider>().value = SaveSystem.LoadCaprices().servesCaprice;
    }
	
	// Update is called once per frame
	void Update () {
        prepTimeCaprice = Mathf.RoundToInt(prepTimeSlide.GetComponent<Slider>().value);
        servesCaprice = Mathf.RoundToInt(servesSlide.GetComponent<Slider>().value);

        SaveSystem.SaveCaprices(this);
	}
    void OnDestroy()
    {
        
    }
    public void SetCheeseCaprice()
    {
        if (cheeseCaprice == true)
        {
            cheeseCaprice = false;
            cheeseGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (cheeseCaprice == false)
        {
            cheeseCaprice = true;
            cheeseGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetGarlicCaprice()
    {
        if (garlicCaprice == true)
        {
            garlicCaprice = false;
            garlicGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (garlicCaprice == false)
        {
            garlicCaprice = true;
            garlicGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetMilkCaprice()
    {
        if (milkCaprice == true)
        {
            milkCaprice = false;
            milkGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (milkCaprice == false)
        {
            milkCaprice = true;
            milkGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetFlourCaprice()
    {
        if (flourCaprice == true)
        {
            flourCaprice = false;
            flourGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (flourCaprice == false)
        {
            flourCaprice = true;
            flourGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetMushroomsCaprice()
    {
        if (mushroomsCaprice == true)
        {
            mushroomsCaprice = false;
            mushroomsGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (mushroomsCaprice == false)
        {
            mushroomsCaprice = true;
            mushroomsGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetPeasCaprice()
    {
        if (peasCaprice == true)
        {
            peasCaprice = false;
            peasGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (peasCaprice == false)
        {
            peasCaprice = true;
            peasGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetEggCaprice()
    {
        if (eggCaprice == true)
        {
            eggCaprice = false;
            eggGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (eggCaprice == false)
        {
            eggCaprice = true;
            eggGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetPastaCaprice()
    {
        if (pastaCaprice == true)
        {
            pastaCaprice = false;
            pastaGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (pastaCaprice == false)
        {
            pastaCaprice = true;
            pastaGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    public void SetButterCaprice()
    {
        if (butterCaprice == true)
        {
            butterCaprice = false;
            butterGameObject.GetComponent<Image>().color = new Color(0.1843137f, 0.8862745f, 0f);
            
        }
        else if (butterCaprice == false)
        {
            butterCaprice = true;
            butterGameObject.GetComponent<Image>().color = new Color(1f, 0f, 0f);

        }

    }
    
}
