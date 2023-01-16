using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Giovannis.Modelos.Clases
{
    internal class Promocion
    {
        private string _codigo;
        private int _descuento;
        private int _activo;
        public static List<Promocion> _promociones = new List<Promocion>();
       
        public Promocion(string codigo, int descuento, int activo)
        {
            _codigo = codigo;
            _descuento = descuento;
            _activo = activo;
        }

        public string Codigo { get => _codigo; set => _codigo = value; }
        public int Descuento { get => _descuento; set => _descuento = value; }
        public int Activo { get => _activo; set => _activo = value; }
        
        public static Boolean cargar_promociones()
        {


            try
            {
                using (StreamReader sr = new StreamReader(@".\Data\promociones.csv"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] p = line.Split(',');
                        Promocion._promociones.Add(new Promocion(p[0], int.Parse(p[1]), int.Parse(p[2])));
                        
                    }
                    sr.Close();
                    return true;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static Boolean volcar_promociones(List<Promocion> promos)
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(@".\Data\promociones.csv"))
                {
                    string cadena = "";
                    for (int i = 0; i < promos.Count; i++)
                    {
                        cadena = cadena + promos[i].Codigo + "," + promos[i].Descuento.ToString() + "," + promos[i].Activo.ToString() + "\n";
                    }

                    sr.WriteLine(cadena);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }


    }


}
