using System;

namespace codicioso
{
    class numDeMonedas
    {//monedas
    public int m5 {get; set;}
    public int m1 {get; set;}
    public int m50C {get; set;}
    public int m10C {get; set;}
    public int m1C {get; set;}
    public int cambio_en_monedas {get; set;}
       public static numDeMonedas numeroDeMonedas(float seDebeCambio)
        {//--nummonedas---
            float monedaDeCinco = 5.0f;
            float monedaDePeso = 1.0f;
            float monedaDeCincuetaCentavos = 0.5f;
            float mondedaDeDiezCentavos = 0.1f;
            float monedaDeUnCentavo = 0.01f;
            int cambio_en_monedas,m5, m1,m50C,m10C,m1C;
            float mod,val_entero,mod2,val_entero1,mod3,val_entero3,mod4,valentero4,val_entero5;

          mod = seDebeCambio%monedaDeCinco; 
          val_entero = seDebeCambio-mod;
          int a = Convert.ToInt32(val_entero);
          m5 = a/5;

          mod2 = mod%monedaDePeso;
          val_entero1= mod-mod2;
          int b = Convert.ToInt32(val_entero1);
          m1 = b/1;

          mod3 = mod2%monedaDeCincuetaCentavos;
          val_entero3 = mod2-mod3;
          float c = val_entero3/monedaDeCincuetaCentavos;
          m50C = Convert.ToInt32(c);

          mod4 = mod3%mondedaDeDiezCentavos;
          valentero4 = mod3-mod4;
          float d = valentero4/mondedaDeDiezCentavos;
          m10C = Convert.ToInt32(d);
          val_entero5 = mod4/monedaDeUnCentavo;
          m1C = Convert.ToInt32(val_entero5);

          cambio_en_monedas = m5 + m1 + m50C + m10C + m1C;

          numDeMonedas datosresult = new numDeMonedas();
          datosresult.m5 = m5;
          datosresult.m1 = m1;
          datosresult.m50C = m50C;
          datosresult.m10C = m10C;
          datosresult.m1C = m1C;
          datosresult.cambio_en_monedas = cambio_en_monedas;
        return datosresult;
        }
    }
}