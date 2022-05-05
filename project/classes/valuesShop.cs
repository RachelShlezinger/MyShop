using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project.classes
{
    public class valuesShop : Controller
    {
    // GET: valuesShop

    public partial class ValuesShop
    {
      public decimal Id { get; set; }
      public string Name { get; set; }
      public List<ValuesShop> List { get; set; }
    }

  }
}