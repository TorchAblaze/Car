using System;

namespace Dealership.Models {

  public class Car
  {
    private string _makeModel;

    public string MakeModel //public property
    {
        get
        {
            return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!"; //property performing 'read' action
        }
        set
        {
            _makeModel = value; //property performing 'write' action
            // 'value' is a keyword apparently
        }
    }
    private int _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }

}