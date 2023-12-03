using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using Xamarin.Forms;

namespace lab12.Model
{
    public class FormularioModel
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Descripcion { get; set; }


        public FormularioModel(string title, bool status, string descripcion)
        {
            Title = title;
            Status = status;
            Descripcion = descripcion;

        }

    }
}