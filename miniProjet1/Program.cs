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


        }

       
    }

    class ArtGalery
    {
       public bool ArtSelect(ArtPiece piece)
        {

        }
        
    }

    enum Categories { PAINTING, SCULPTURE,DRAWING};
    

    


    class ArtPiece : IComparable
    {
        String Title;
        Categories Categorie;
        int Price;

        public int CompareTo(object obj)
        {
            return Price.CompareTo((obj as ArtPiece).Price);
        }

    }




}

