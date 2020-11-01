using System;
using System.Text.RegularExpressions;

namespace Validaciones
{
    public class Cadenas
    {
        private static Regex Regexx { get; set; }

        private const string email = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9]){1,3}?)\Z";

        private const string contrasenFuerte = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).{6,50}+$";

        private const string letras = @"^[a-zA-Z]+$";

        private const string numeros = @"^[0-9]+$";

        private const string url = @"((https?):/?/?)(?:(.*?)(?::(.*?)|)@)?([^:/\s]+)(:([^/]*))?(((?:/\w+)*)/)([-\w.]+[^#?\s]*)?(\?([^#]*))?(#(.*))?/";
        public Cadenas()
        {
        }

        public static bool validarEmail(string val)
        {
            try
            {
                Regexx = new Regex(email);

                if (Regexx.IsMatch(val))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }
        public static bool validarURL(string val)
        {
            try
            {
                Regexx = new Regex(url);

                if (Regexx.IsMatch(val))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool validarContrasena(string val)
        {
            try
            {
                Regexx = new Regex(contrasenFuerte);

                if (Regexx.IsMatch(val))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool validarNumeros(string val,int inicio=0,int final=0)
        {
            string local = "";
            try
            {
                if (inicio>0||final>0)
                {
                    local = @"^[0-9]{"+inicio+","+final+"}$";

                    Regexx = new Regex(local);
                }
                else
                {
                    Regexx = new Regex(numeros);
                }

                if (Regexx.IsMatch(val))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool validarLetras(string val, int inicio = 0, int final = 0)
        {
            string local = "";
            try
            {
                if (inicio > 0 || final > 0)
                {
                    local = @"^[a-zA-Z]{"+inicio+","+final+"}$";

                    Regexx = new Regex(local);
                }
                else
                {
                    Regexx = new Regex(letras);
                }

                if (Regexx.IsMatch(val))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool validarLetrasYNumerosLength(string val, int inicio, int final)
        {
            try
            {

                Regexx = new Regex(@"^[a-zA-Z0-9]{"+inicio+","+final+"}$");
                

                if (Regexx.IsMatch(val))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
