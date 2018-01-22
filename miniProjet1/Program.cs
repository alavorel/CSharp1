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
            int z=0;
            Program test = new Program();
            String str = "le nombre z est =";
            PremiereClass nvlinstance= new PremiereClass();
            nvlinstance.Ss_programeClass();
            z = nvlinstance.geta();
            z = test.Ss_programe(z);
            str = str + z;
            Console.WriteLine(str);
            Console.ReadLine();

        }

        private int Ss_programe(int a )
        {

            return a;
        }
    }

    class PremiereClass
    {
        int a;

       public void Ss_programeClass()
        {
            a = 0;
            a++;
        }

        public int geta()
        {
            return a;
        }
        
    }







}

