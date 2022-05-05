using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static project.classes.valuesShop;

namespace project.Controllers
{
  public class HomeController : ApiController
  {
    [System.Web.Http.HttpGet]
    public List<ValuesShop> shop(string filter = null)
    {
      List<ValuesShop> list = new List<ValuesShop>() {
          new ValuesShop { Id = 01, Name = "רהיטים", List =  new List<ValuesShop> {
              new ValuesShop  { Id = 011, Name = "ארונות" },
              new ValuesShop  { Id = 012, Name = "שולחנות" },
              new ValuesShop  { Id = 013, Name = "ספריות" },
              new ValuesShop  { Id = 014, Name = "מיטות" },
            }
          },
          new ValuesShop { Id = 02, Name = "בגדים", List =  new List<ValuesShop> {
              new ValuesShop  { Id = 021, Name = "בגדי ילדים" },
              new ValuesShop  { Id = 022, Name = "בגדי נשים" },
              new ValuesShop  { Id = 023, Name = "ניו בורן" },
              new ValuesShop  { Id = 024, Name = "בגדי גברים" },
            }
          },
          new ValuesShop { Id = 03, Name = "משחקים", List =  new List<ValuesShop> {
              new ValuesShop  { Id = 031, Name = "משחקי חצר" },
              new ValuesShop  { Id = 032, Name = "משחקי קופסא" },
              new ValuesShop  { Id = 033, Name = "כלי בובה" },
            }
          },
          new ValuesShop { Id = 04, Name = "כלי בית", List =  new List<ValuesShop> {
              new ValuesShop  { Id = 041, Name = "כלי מטבח" },
              new ValuesShop  { Id = 042, Name = "כלי עבודה" },
            }
          },
      };

      if (filter != null)
      {
        list = list.Where(x => x.Name.Contains(filter)).ToList();
      }
      return list;
    }
  }
}
