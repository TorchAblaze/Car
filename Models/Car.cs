using System;

namespace Dealership.Models {

  public class Car
  {
    public string MakeModel { get; set; } //public property
    // {
    //     get
    //     {
    //         return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!"; //property performing 'read' action
    //     }
    //     set
    //     {
    //         _makeModel = value; //property performing 'write' action
    //         // 'value' is a keyword apparently
    //     }
    // }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    // public string MakeModel()
    // {
    //   return MakeModel;
    // }

    // public int Price()
    // {
    //   return Price;
    // }

    // public int Miles()
    // {
    //   return Miles;
    // }

    // public void Price(int newPrice)
    // {
    //   Price = newPrice;
    // }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }

}