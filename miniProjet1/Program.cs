using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Burgelin_Lavorel_rosenzweig_tp1
{
    class Program
    {
        //methode main
        static void Main(string[] args)
        {
            Program myprog = new Program();
            myprog.Process();

        }

        public void Process()
        {

            ArtGalery myGalery = new ArtGalery();
            myGalery.Initialize();

            myGalery.Sort();

            SculptureUnder100 scp = new SculptureUnder100();
            Console.WriteLine("\n\nSculpture under 100:\n");
            myGalery.ProcessArtPiece(scp);


            PaintingOver100 pnt = new PaintingOver100();
            Console.WriteLine("\n\nPainting over 100:\n");
            myGalery.ProcessArtPiece(pnt);

            Console.WriteLine("\n\nBase selection: everything over 150:\n");
            myGalery.ProcessArtPiece(myGalery);




        }

        class SculptureUnder100 : IArtSelect
        {

            public bool Select(ArtPiece piece)
            {
                if ((piece.Price < 100) && (piece.Categorie == Categories.SCULPTURE))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        class PaintingOver100 : IArtSelect
        {
            public bool Select(ArtPiece piece)
            {
                if ((piece.Price > 100) && (piece.Categorie == Categories.PAINTING))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }

    class ArtGalery : IArtSelect
    {
        private ArtPiece[] Collection;

        public void Initialize()
        {
            Collection = new ArtPiece[12];
            Collection[0] = new ArtPiece("Bold and Brash", Categories.PAINTING, 140);
            Collection[1] = new ArtPiece("Le Brasseur", Categories.SCULPTURE, 40);
            Collection[2] = new ArtPiece("L'Uomo Vitruviano", Categories.DRAWING, 200);
            Collection[3] = new ArtPiece("PopArt", Categories.PAINTING, 105);
            Collection[4] = new ArtPiece("Le Penseur", Categories.SCULPTURE, 180);
            Collection[5] = new ArtPiece("Picasso Sketch", Categories.DRAWING, 193);
            Collection[6] = new ArtPiece("Un Serpent Boa qui Digérait un Éléphant", Categories.DRAWING, 25);
            Collection[7] = new ArtPiece("Mouton Dessiné", Categories.DRAWING, 78);
            Collection[8] = new ArtPiece("Gernika", Categories.PAINTING, 135);
            Collection[9] = new ArtPiece("Belongs in the Trash", Categories.PAINTING, 20);
            Collection[10] = new ArtPiece("Davide de Bernini", Categories.SCULPTURE, 130);
            Collection[11] = new ArtPiece("Badly Shapen Pot", Categories.SCULPTURE, 25);
        }

        public void ProcessArtPiece(IArtSelect selector)
        {
            Console.WriteLine("Selected art pieces for you are : \n");
            for (int i = 0; i < 12; i++)
            {
                if (selector.Select(Collection[i]))
                {
                    Console.WriteLine(Collection[i]);
                }
            }
            Console.ReadKey();

        }

        public void Sort()
        {

           
            Array.Sort(Collection, new PriceComparer());

            Console.WriteLine("Sorted collection is :\n");

            for (int i = 0; i < 12; i++)
            {
                
                    Console.WriteLine(Collection[i]);
               
            }
            Console.ReadKey();

        }


        public bool Select(ArtPiece piece)
        {
            if (piece.Price > 150)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       



    }

    interface IArtSelect
    {
        Boolean Select(ArtPiece piece);
    }

    enum Categories { PAINTING, SCULPTURE, DRAWING };





    class ArtPiece : IComparable
    {
        String m_title;
        Categories m_categorie;
        int m_price;

        public ArtPiece(string _Title, Categories _cat, int _price)
        {
            m_title = _Title;
            m_categorie = _cat;
            m_price = _price;

        }
        public Categories Categorie { get{return m_categorie; } set {m_categorie=value; } }

        public int Price { get { return m_price; } set {m_price=value; }     }


        public int CompareTo(object obj)
        {
            return m_price.CompareTo((obj as ArtPiece).m_price);
        }

        public override string ToString()
        {
            return "Titre: " + m_title + " Catégorie: " + m_categorie + " Price: " + m_price;
        }

    }

    class PriceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (x as ArtPiece).Price.CompareTo((y as ArtPiece).Price);
        }
    }
}




