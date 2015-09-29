using System;
using System.Collections;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Bags
/// </summary>
public class Bag
{

    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Review { get; set; }

        public Bag(int id, string name, string type, double price, string image, string review)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
            Image = image;
            Review = review;
        }
    
	
}