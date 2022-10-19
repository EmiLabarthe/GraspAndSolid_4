using System.Collections.Generic;
using Full_GRASP_And_SOLID;
using System;
using System.Linq;

namespace Full_GRASP_And_SOLID;

public class Catalog
{
    // Se crea esta clase ya que eran funciones que se hacían en el program
    // Esta clase a la vez crea Products and Equipments, ya que usa estos objetos y guarda sus instancias
    public Catalog()
    {

    }
    public static List<Product> productCatalog = new List<Product>();

    public static List<Equipment> equipmentCatalog = new List<Equipment>();
    
    public void AddProductToCatalog(string description, double unitCost)
    {
        productCatalog.Add(new Product(description, unitCost));
    }

    public void AddEquipmentToCatalog(string description, double hourlyCost)
    {
        equipmentCatalog.Add(new Equipment(description, hourlyCost));
    }

    public Product ProductAt(int index)
    {
        return productCatalog[index] as Product;
    }

    public Equipment EquipmentAt(int index)
    {
        return equipmentCatalog[index] as Equipment;
    }

    public Product GetProduct(string description)
    {
        var query = from Product product in productCatalog where product.Description == description select product;
        return query.FirstOrDefault();
    }

    public Equipment GetEquipment(string description)
    {
        var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
        return query.FirstOrDefault();
    }
}