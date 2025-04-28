using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaMudanzas : MonoBehaviour
{
    public int CantidadCarga;
    public int DistanciaKM;
    // Start is called before the first frame update
    void Start()
    {

        if (CantidadCarga < 100)
        {
            Debug.Log("Error, la carga debe ser mayor a 100kg");
            return;

        } else if (DistanciaKM < 1) {
            Debug.Log("Error, la distancia debe ser mayor a 1km");
            return;

        } else
        {
            int PrecioHoraU = 3000;
            int PrecioHoraP = 4500;
            int PrecioHoraC = 7000;
            float CantidadHoras = (DistanciaKM * 1) / 25;
            if (CantidadCarga <= 2000)
            {
                Debug.Log("Vas a necesitar un vehículo Utilitario que tardará " + CantidadHoras + " horas en llegar al destino");
            
                float PrecioTotal = CantidadHoras * PrecioHoraU;
                Debug.Log("Precio total " + CantidadHoras + " horas a $ " + PrecioHoraU + " : $ " + PrecioTotal);

            } else if(DistanciaKM > 50)
            {
                float PrecioTotal1 = CantidadHoras * PrecioHoraU + 3000;
                Debug.Log("Precio total " + CantidadHoras + " horas a $ " + PrecioHoraU + " : $ " + PrecioTotal1);
            }

            if (CantidadCarga > 2000 && CantidadCarga <= 5000)
            {
                Debug.Log("Vas a necesitar un vehículo Pickup que tardará " + CantidadHoras + " horas en llegar al destino");
                
                float PrecioTotal = CantidadHoras * PrecioHoraP;
                Debug.Log("Precio total " + CantidadHoras + " horas a $ " + PrecioHoraP + " : $ " + PrecioTotal);

            } else if (DistanciaKM > 50)
            {
                float PrecioTotal1 = CantidadHoras * PrecioHoraP + 4500;
                Debug.Log("Precio total " + CantidadHoras + " horas a $ " + PrecioHoraP + " : $ " + PrecioTotal1);
            }

            if (CantidadCarga > 5000 && CantidadCarga <= 10000)
            {
                Debug.Log("Vas a necesitar un vehículo Camión que tardará " + CantidadHoras + " horas en llegar al destino");
                
                float PrecioTotal = CantidadHoras * PrecioHoraC;
                Debug.Log("Precio total " + CantidadHoras + " horas a $ " + PrecioHoraC + " : $ " + PrecioTotal);
            } else if (DistanciaKM > 50)
            {
                float PrecioTotal1 = CantidadHoras * PrecioHoraC + 7000;
                Debug.Log("Precio total " + CantidadHoras + " horas a $ " + PrecioHoraC + " : $ " + PrecioTotal1);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
