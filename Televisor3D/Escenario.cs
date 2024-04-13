using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace Televisor3D
{
    internal class Escenario
    {
        List<Object> objetos;

        public Escenario()
        {
            objetos = new List<Object>();
        }

        public void Add(Object obj) 
        {
            this.objetos.Add(obj);
        }

        public void Remove(Object obj)
        {
            this.objetos.Remove(obj);
        }
        public void Clear()
        {
            this.objetos= new List<Object>();
        }

        public void Dibujar()
        {
            Objeto tele = new Objeto(0.3, -0.9, -0.05);
            Cara pantalla = new Cara(Color.Black, PrimitiveType.Quads);
            pantalla.addVertice(new Double[] { 0.03f, 0.04f, -0.03f });
            pantalla.addVertice(new Double[] { 0.03f, 0.36f, -0.03f });
            pantalla.addVertice(new Double[] { 0.47f, 0.36f, -0.03f });
            pantalla.addVertice(new Double[] { 0.47f, 0.04f, -0.03f });

            Cara paredAdelante = new Cara(Color.DarkBlue, PrimitiveType.Quads);
            paredAdelante.addVertice(new Double[] { 0f, 0f, -0.03f });
            paredAdelante.addVertice(new Double[] { 0.5f, 0f, -0.03f });
            paredAdelante.addVertice(new Double[] { 0.5f, 0.4f, -0.03f });
            paredAdelante.addVertice(new Double[] { 0f, 0.4f, -0.03f });

            Cara soporte = new Cara(Color.Yellow, PrimitiveType.Quads);
            soporte.addVertice(new Double[] { 0.22f, 0f, -0.03f });
            soporte.addVertice(new Double[] { 0.22f, -0.05f, -0.03f });
            soporte.addVertice(new Double[] { 0.26f, -0.05f, -0.03f });
            soporte.addVertice(new Double[] { 0.26f, 0f, -0.03f });

            Cara soporte1 = new Cara(Color.Yellow, PrimitiveType.Quads);
            soporte1.addVertice(new Double[] { 0.12f, -0.05f, -0.03f });
            soporte1.addVertice(new Double[] { 0.12f, -0.06f, -0.03f });
            soporte1.addVertice(new Double[] { 0.36f, -0.06f, -0.03f });
            soporte1.addVertice(new Double[] { 0.36f, -0.05f, -0.03f });

            Cara paredAtras = new Cara(Color.DarkKhaki, PrimitiveType.Quads);
            paredAtras.addVertice(new Double[] { 0f, 0f, 0f });
            paredAtras.addVertice(new Double[] { 0.5f, 0f, 0f });
            paredAtras.addVertice(new Double[] { 0.5f, 0.4f, 0f });
            paredAtras.addVertice(new Double[] { 0f, 0.4f, 0f });

            Cara soporteA = new Cara(Color.Aquamarine, PrimitiveType.Quads);
            soporteA.addVertice(new Double[] { 0.22f, 0f, 0f });
            soporteA.addVertice(new Double[] { 0.22f, -0.05f, 0f });
            soporteA.addVertice(new Double[] { 0.26f, -0.05f, 0f });
            soporteA.addVertice(new Double[] { 0.26f, 0f, 0f });

            Cara soporteB = new Cara(Color.Aquamarine, PrimitiveType.Quads);
            soporteB.addVertice(new Double[] { 0.12f, -0.05f, 0f });
            soporteB.addVertice(new Double[] { 0.12f, -0.06f, 0f });
            soporteB.addVertice(new Double[] { 0.36f, -0.06f, 0f });
            soporteB.addVertice(new Double[] { 0.36f, -0.05f, 0f });

            Cara lateral1 = new Cara(Color.DarkGray, PrimitiveType.Quads);
            lateral1.addVertice(new Double[] { 0f, 0f, 0f });
            lateral1.addVertice(new Double[] { 0f, 0f, -0.03f });
            lateral1.addVertice(new Double[] { 0f, 0.4f, -0.03f });
            lateral1.addVertice(new Double[] { 0f, 0.4f, 0f });

            Cara lateral2 = new Cara(Color.DarkGreen, PrimitiveType.Quads);
            lateral2.addVertice(new Double[] { 0.5f, 0f, 0f });
            lateral2.addVertice(new Double[] { 0.5f, 0f, -0.03f });
            lateral2.addVertice(new Double[] { 0.5f, 0.4f, -0.03f });
            lateral2.addVertice(new Double[] { 0.5f, 0.4f, 0f });

            Cara lateral3 = new Cara(Color.Red, PrimitiveType.Quads);
            lateral3.addVertice(new Double[] { 0.12f, -0.05f, 0f });
            lateral3.addVertice(new Double[] { 0.12f, -0.05f, -0.03f });
            lateral3.addVertice(new Double[] { 0.12f, -0.06f, -0.03f });
            lateral3.addVertice(new Double[] { 0.12f, -0.06f, 0f });

            Cara lateral4 = new Cara(Color.Red, PrimitiveType.Quads);
            lateral4.addVertice(new Double[] { 0.36f, -0.05f, 0f });
            lateral4.addVertice(new Double[] { 0.36f, -0.05f, -0.03f });
            lateral4.addVertice(new Double[] { 0.36f, -0.06f, -0.03f });
            lateral4.addVertice(new Double[] { 0.36f, -0.06f, 0f });

            Cara lateral5 = new Cara(Color.Red, PrimitiveType.Quads);
            lateral5.addVertice(new Double[] { 0.22f, -0.05f, 0f });
            lateral5.addVertice(new Double[] { 0.22f, -0.05f, -0.03f });
            lateral5.addVertice(new Double[] { 0.22f, 0f, -0.03f });
            lateral5.addVertice(new Double[] { 0.22f, 0f, 0f });

            Cara lateral6 = new Cara(Color.Red, PrimitiveType.Quads);
            lateral6.addVertice(new Double[] { 0.26f, -0.05f, 0f });
            lateral6.addVertice(new Double[] { 0.26f, -0.05f, -0.03f });
            lateral6.addVertice(new Double[] { 0.26f, 0f, -0.03f });
            lateral6.addVertice(new Double[] { 0.26f, 0f, 0f });

            tele.addCara(pantalla);
            tele.addCara(paredAdelante);
            tele.addCara(soporte);
            tele.addCara(soporte1);
            tele.addCara(paredAtras);
            tele.addCara(soporteA);
            tele.addCara(soporteB);
            tele.addCara(lateral1);
            tele.addCara(lateral2);
            tele.addCara(lateral3);
            tele.addCara(lateral4);
            tele.addCara(lateral5);

            tele.Dibujar();

            Objeto jarron = new Objeto(0.3, -0.9, -0.05);
            Cara adelante = new Cara(Color.BlueViolet, PrimitiveType.Polygon);
            adelante.addVertice(new Double[] { 0.04f, 0.4f, -0.03f });
            adelante.addVertice(new Double[] { 0.22f, 0.4f, -0.03f });
            adelante.addVertice(new Double[] { 0.22f, 0.7f, -0.03f });
            adelante.addVertice(new Double[] { 0.26f, 0.9f, -0.03f });
            adelante.addVertice(new Double[] { 0.06f, 0.9f, -0.03f });

            Cara atras = new Cara(Color.Pink, PrimitiveType.Polygon);
            atras.addVertice(new Double[] { 0.04f, 0.4f, 0f });
            atras.addVertice(new Double[] { 0.22f, 0.4f, 0f });
            atras.addVertice(new Double[] { 0.22f, 0.7f, 0f });
            atras.addVertice(new Double[] { 0.26f, 0.9f, 0f });
            atras.addVertice(new Double[] { 0.06f, 0.9f, 0f });

            Cara lteral1 = new Cara(Color.DarkMagenta, PrimitiveType.Polygon);
            lteral1.addVertice(new Double[] { 0.04f, 0.4f, 0f });
            lteral1.addVertice(new Double[] { 0.04f, 0.4f, -0.03f });
            lteral1.addVertice(new Double[] { 0.06f, 0.9f, -0.03f });
            lteral1.addVertice(new Double[] { 0.06f, 0.9f, 0f });

            Cara lteral2 = new Cara(Color.DarkMagenta, PrimitiveType.Polygon);
            lteral2.addVertice(new Double[] { 0.22f, 0.4f, 0f });
            lteral2.addVertice(new Double[] { 0.22f, 0.7f, 0f });
            lteral2.addVertice(new Double[] { 0.26f, 0.9f, 0f });
            lteral2.addVertice(new Double[] { 0.26f, 0.9f, -0.03f });
            lteral2.addVertice(new Double[] { 0.22f, 0.7f, -0.03f });
            lteral2.addVertice(new Double[] { 0.22f, 0.4f, -0.03f });

            jarron.addCara(adelante);
            jarron.addCara(atras);
            jarron.addCara(lteral1);
            jarron.addCara(lteral2);
            jarron.Dibujar();

            Objeto reproductor = new Objeto(-0.9, 0.9, 0.0);
            Cara ad = new Cara(Color.Black, PrimitiveType.Polygon);
            ad.addVertice(new Double[] { 0f, 0f, 0f });
            ad.addVertice(new Double[] { 0.4f, 0f, 0f });
            ad.addVertice(new Double[] { 0.4f, 0.7f, 0f });
            ad.addVertice(new Double[] { 0f, 0.7f, 0f });

            Cara aa = new Cara(Color.Gold, PrimitiveType.Polygon);
            aa.addVertice(new Double[] { 0f, 0f, -0.52f });
            aa.addVertice(new Double[] { 0.4f, 0f, -0.52f });
            aa.addVertice(new Double[] { 0.4f, 0.7f, -0.52f });
            aa.addVertice(new Double[] { 0f, 0.7f, -0.52f });

            Cara p1 = new Cara(Color.Blue, PrimitiveType.Quads);
            p1.addVertice(new Double[] { 0f, 0f, 0f });
            p1.addVertice(new Double[] { 0f, 0f, -0.52f });
            p1.addVertice(new Double[] { 0f, 0.7f, -0.52f });
            p1.addVertice(new Double[] { 0f, 0.7f, 0f });

            Cara p2 = new Cara(Color.Blue, PrimitiveType.Quads);
            p2.addVertice(new Double[] { 0.4f, 0f, 0f });
            p2.addVertice(new Double[] { 0.4f, 0f, -0.52f });
            p2.addVertice(new Double[] { 0.4f, 0.7f, -0.52f });
            p2.addVertice(new Double[] { 0.4f, 0.7f, 0f });

            Cara ad1 = new Cara(Color.Black, PrimitiveType.Polygon);
            ad1.addVertice(new Double[] { 0.5f, 0f, 0f });
            ad1.addVertice(new Double[] { 0.9f, 0f, 0f });
            ad1.addVertice(new Double[] { 0.9f, 0.7f, 0f });
            ad1.addVertice(new Double[] { 0.5f, 0.7f, 0f });

            Cara aa1 = new Cara(Color.Gold, PrimitiveType.Polygon);
            aa1.addVertice(new Double[] { 0.5f, 0f, -0.52f });
            aa1.addVertice(new Double[] { 0.9f, 0f, -0.52f });
            aa1.addVertice(new Double[] { 0.9f, 0.7f, -0.52f });
            aa1.addVertice(new Double[] { 0.5f, 0.7f, -0.52f });

            Cara pa1 = new Cara(Color.Blue, PrimitiveType.Quads);
            pa1.addVertice(new Double[] { 0.5f, 0f, 0f });
            pa1.addVertice(new Double[] { 0.5f, 0f, -0.52f });
            pa1.addVertice(new Double[] { 0.5f, 0.7f, -0.52f });
            pa1.addVertice(new Double[] { 0.5f, 0.7f, 0f });

            Cara pa2 = new Cara(Color.Blue, PrimitiveType.Quads);
            pa2.addVertice(new Double[] { 0.9f, 0f, 0f });
            pa2.addVertice(new Double[] { 0.9f, 0f, -0.52f });
            pa2.addVertice(new Double[] { 0.9f, 0.7f, -0.52f });
            pa2.addVertice(new Double[] { 0.9f, 0.7f, 0f });

            reproductor.addCara(ad);
            reproductor.addCara(aa);
            reproductor.addCara(p1);
            reproductor.addCara(p2);
            reproductor.addCara(ad1);
            reproductor.addCara(aa1);
            reproductor.addCara(pa1);
            reproductor.addCara(pa2);
            reproductor.Dibujar();
        }
    }
}
