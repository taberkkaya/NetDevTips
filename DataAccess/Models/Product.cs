﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

//[Index(nameof(Product.Name), IsUnique =true)]
//[Index(nameof(Product.Name))]
public sealed class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
