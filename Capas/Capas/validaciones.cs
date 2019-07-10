using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Capas
{
    public class validaciones
    {

            public void  SoloLetras(KeyPressEventArgs V)
            {
                if (Char.IsLetter(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsControl(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsSeparator(V.KeyChar))
                {
                    V.Handled = false;
                }
                else
                {
                    V.Handled = true;
                }
            }
            public void SoloNumeros(KeyPressEventArgs V)
            {
                if (Char.IsDigit(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsSeparator(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsControl(V.KeyChar))
                {
                    V.Handled = false;
                }
                else
                {
                    V.Handled = true;
                }
         
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;
                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar Vacio");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(Obj, "");
                    }
                }
            }
            return HayErrores;
        }

    }







}


