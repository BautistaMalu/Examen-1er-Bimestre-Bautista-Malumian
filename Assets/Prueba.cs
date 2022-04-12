using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    public int platea;
    public int campo;
    int totalp;
    int totalc;
    int total;
    int entradas = 36600;
      void Start()
    {
        total = platea + campo;
        totalc = campo * 1200;
        totalp = platea * 2000;
        
        if (platea > 16200)
        {
            Debug.Log("Error(demasiadas de entradas vendidas en platea)");
        }
        else if (campo > 20400)
        {
            Debug.Log("Error(demasiadas de entradas vendidas en campo)");
        }
        else if (total < 0)
        {
            Debug.Log("Error(falta ingreso de ventas)");
        }

        else if (total >= 18300)
        {
            Debug.Log("El festival fue un exito");
            Debug.Log("Se recaudaron " + totalc + "$ en entradas de campo, " + totalp + "$ entradas de platea y el total recaudado es de " + (totalc+totalp) + "$");
            Debug.Log("Quedaron " + (entradas-total) + " entradas sin vender");
        }
        else if (total < 18300)
        {
            Debug.Log("Debemos mejorar la convocatoria");
            Debug.Log("Se recaudaron " + totalc + "$ en entradas de campo, " + totalp + "$ entradas de platea y el total recaudado es de " + (totalc + totalp) + "$");
            Debug.Log("Quedaron " + (entradas - total) + " entradas sin vender");
        }
        else if (total == 36600)
        {
            Debug.Log("Sold Out");
            Debug.Log("Se recaudaron " + totalc + "$ en entradas de campo, " + totalp + "$ entradas de platea y el total recaudado es de " + (totalc + totalp) + "$");
        }
    }


}
