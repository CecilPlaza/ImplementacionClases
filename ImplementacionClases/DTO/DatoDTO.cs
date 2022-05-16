using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionClases.DTO
{
    public class DatoDTO
    {
        private int id;
        private float flujo;
        private float nivel;
        private float temperatura;
        private float voltaje;
        private CeldaDTO celdas;
        private BancoDTO banco;

        private List<DatoDTO> datos = new List<DatoDTO>
        {
            new DatoDTO(){id=1, flujo=0, nivel=0, temperatura=0, voltaje=0},
            new DatoDTO(){id=2, flujo=1.1f, nivel =2.0f, temperatura=4.3f, voltaje=1.1f},
            new DatoDTO(){id=3, flujo=2.3f, nivel =3.0f, temperatura=3.1f, voltaje=2.0f},
        };


        public int Id { get => id; set => id = value; }
        public float Flujo { get => flujo; set => flujo = value; }
        public float Nivel { get => nivel; set => nivel = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public float Voltaje { get => voltaje; set => voltaje = value; }
        public float TemperaturaFarenheit { get => temperatura * (9 / 5) + 32; }
        public CeldaDTO Celdas { get => celdas; set => celdas = value; }
        public BancoDTO Banco { get => banco; set => banco = value; }

        //Metodos
        public static bool Add(DatoDTO datos)
        { 
            try
            {
                datos.Add(nuevosDatos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
