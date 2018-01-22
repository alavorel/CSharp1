using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Process() {

            ArtGalery myGalery = new ArtGalery();
            myGalery.Initialize();



        }

        class SculptureUnder100
        {

        }

        class PaintingOver100
        {

        }

    }

    class ArtGalery
    {
        ArtPiece[] Collection;

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

        public ProcessArtPiece()
        {

        }

        public Select()
        {

        }

        public Sort{
        
            
        }


    }

    interface IArtSelect
    {
        Boolean Select(ArtPiece piece);
    }

    enum Categories { PAINTING, SCULPTURE,DRAWING};
    

    


    class ArtPiece : IComparable
    {
        String m_title;
        Categories m_categorie;
        int m_price;

        public ArtPiece(string _Title, Categories _cat, int _price)
        {
            m_title =_Title;
            m_categorie =_cat;
            m_price =_price;
        }



        public int CompareTo(object obj)
        {
            return m_price.CompareTo((obj as ArtPiece).m_price);
        }

        

    }

