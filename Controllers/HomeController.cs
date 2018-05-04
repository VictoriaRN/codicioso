using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using codicioso.Models;

namespace codicioso.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult NumMonedas(float DineroQueseDebe)
        {
            int cambio_en_monedas,m5, m1,m50C,m10C,m1C;
            float mod,val_entero,mod2,val_entero1,mod3,val_entero3,mod4,valentero4,val_entero5;

          mod = DineroQueseDebe%5.0f; 
          val_entero = DineroQueseDebe-mod;
          int a = Convert.ToInt32(val_entero);
          m5 = a/5;

          mod2 = mod%1.0f;
          val_entero1= mod-mod2;
          int b = Convert.ToInt32(val_entero1);
          m1 = b/1;

          mod3 = mod2%0.5f;
          val_entero3 = mod2-mod3;
          float c = val_entero3/0.5f;
          m50C = Convert.ToInt32(c);

          mod4 = mod3%0.1f;
          valentero4 = mod3-mod4;
          float d = valentero4/0.1f;
          m10C = Convert.ToInt32(d);
          val_entero5 = mod4/0.01f;
          m1C = Convert.ToInt32(val_entero5);

          cambio_en_monedas = m5 + m1 + m50C + m10C + m1C;

            ViewBag.DineroEnMonedas = cambio_en_monedas;
            ViewBag.Monedasde5 = m5;
            ViewBag.Monedasde1 = m1;
            ViewBag.Monedasde50c = m50C;
            ViewBag.Monedasde10c = m10C;
            ViewBag.Monedasde1c = m1C;

            return View();
        }

    }
}
