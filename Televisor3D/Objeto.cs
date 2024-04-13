using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Televisor3D
{
    internal class Objeto
    {
        private List<Cara> caraLista;
        private Double alto, largo, ancho;
        private Vector3d vector; //posicion del objeto

        public Objeto(Double centroX, Double centroY, Double centroZ)
        {
            this.caraLista = new List<Cara>();
            this.vector = new Vector3d(centroX, centroY, centroZ);
            this.alto = 100;
            this.largo = 100;
            this.ancho = 100;
        }
        public Objeto(List<Cara> caralis, Vector3d v, Double largo, Double alto, Double ancho)
        {
            this.caraLista =  caralis;
            this.vector = v;
            this.alto = alto;
            this.largo = largo;
            this.ancho = ancho;
        }

        public Objeto(Objeto objeto)
        {
            this.vector = objeto.vector;
            this.caraLista = objeto.caraLista;
            this.largo=objeto.largo;
            this.ancho=objeto.ancho;
            this.alto=objeto.alto;
        }

        public Double CenterX
        {
            get { return this.vector.X; }
            set { this.vector.X = value; }
        }

        public void addCara(Cara cara)
        {
            this.caraLista.Add(cara);
        }

        public void Dibujar()
        {
            if (this.caraLista.Count != 0)
            {
                foreach (Cara caras in this.caraLista)
                {
                    caras.Dibujar(vector);
                }
            }
        }

    }
}
