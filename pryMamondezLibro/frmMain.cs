using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace pryMamondezLibro
{
    public partial class frmMain : Form
    {
        //declaramos las variables y vectores publicas para manipular el archivo
        public int varIndice = 0;
        Libros[] vecBiblioteca = new Libros[21];
        int varIndiceRecorrido = 0;

        public struct Libros
        {
            public string varCodigoLibro;
            public string varNombre;
            public string varCodigoEditorial;
            public string varCodigoAutor;
            public string varCodigoDistribuidor;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           //Leemos el archivo
            StreamReader srLeerLibro = new StreamReader("./LIBRO.txt");

            while (!srLeerLibro.EndOfStream) //Ponemos que mientras no llegue a fin de archivo
            {
                string varLeerCodigo = srLeerLibro.ReadLine(); //leemos linea
                string[] vecLeerCodigo = varLeerCodigo.Split(','); //utilizamos el split para separar con coma
               
                for (int ind = 0; ind < vecLeerCodigo.Length; ind++)//mientras el indice temporal llamado ind y mientras sea menor
                {                                                   //al largo del vector incrementa su posicion
                   //la funcion regex hace que se borren los espacios en blanco dejando el texto
                    vecLeerCodigo[ind] = Regex.Replace(vecLeerCodigo[ind], @"\t", "");//la t es el indicador para que muestre solo texto
                }
                
                vecBiblioteca[varIndice].varCodigoLibro = vecLeerCodigo[0];
                vecBiblioteca[varIndice].varNombre = vecLeerCodigo[1];
                vecBiblioteca[varIndice].varCodigoEditorial = vecLeerCodigo[2];
                vecBiblioteca[varIndice].varCodigoAutor = vecLeerCodigo[3];
                vecBiblioteca[varIndice].varCodigoDistribuidor = vecLeerCodigo[4];

                NombreDistribuidora(varIndice);
                NombreEditorial(varIndice);
                varIndice++; //incrementamos indice del vector

            }
            srLeerLibro.Close(); //cerramos archivo
        }
        private void NombreDistribuidora(int index)
        {
            StreamReader LeerDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");

            while (!LeerDistribuidora.EndOfStream)
            {
                string[] vecDistribuidora = LeerDistribuidora.ReadLine().Split(',');
                for (int ind = 0; ind < vecDistribuidora.Length; ind++)
                {
                    vecDistribuidora[ind] = Regex.Replace(vecDistribuidora[ind], @"\t", "");
                }

                if (vecDistribuidora[0] == vecBiblioteca[index].varCodigoDistribuidor)
                {
                    vecBiblioteca[index].varCodigoDistribuidor = vecDistribuidora[1];
                }

            }
        
        }
        private void NombreEditorial(int index)
        {
            StreamReader LeerEditorial = new StreamReader("./EDITORIAL.txt");

            while (!LeerEditorial.EndOfStream)
            {
                string[] vecEditorial = LeerEditorial.ReadLine().Split(',');
                for (int ind = 0; ind < vecEditorial.Length; ind++)
                {
                    vecEditorial[ind] = Regex.Replace(vecEditorial[ind], @"\t", "");
                }

                if (vecEditorial[0] == vecBiblioteca[index].varCodigoEditorial)
                {
                    vecBiblioteca[index].varCodigoEditorial = vecEditorial[1];
                }

            }

        }
        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (varIndiceRecorrido < vecBiblioteca.Length) //si el indice del recorrido es menor a la dimencion del vector entra
            {   //grabamos en las cajas de texto lo que esta dentro de la estructura del vector definidas anteriormente
                txtCodigo.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombreLibro.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtCodigoAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                txtCodigoDistribuidor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoDistribuidor;
                varIndiceRecorrido++;

            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            varIndiceRecorrido--;



            if (varIndiceRecorrido >= 0)
            {
                txtCodigo.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombreLibro.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtCodigoAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                txtCodigoDistribuidor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoDistribuidor;

            }
        }
    }
}
