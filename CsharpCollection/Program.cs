using System;
using System.Collections;

namespace ArrayListNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList() { "Hindi", "English", "Math", "Science", "Urdu" };


            //--------ArrayList Add Method-------

                   //ArrayList list new ArrayList();     

                   // list.Add("Ayaz");
                   // list.Add("Engineering");
                   // list.Add("9340336471");
                   // list.Add("Motihari");

                   // Console.WriteLine(list[0]);
                   // Console.WriteLine(list[1]);
                   // Console.WriteLine(list[2]);
                   // Console.WriteLine(list[3]);

                   // foreach (var item in list)
                    //{
                    //       Console.WriteLine(item);
                    //}

         //------ArrayList AddRange Method-----

                 // list.AddRange(al);
                 // foreach (var item in list)
                //    {
                //          Console.WriteLine(item);
                //    }

         //------ArrayList Insert---------------

                    //list.Insert(2, "Sports");
                    // foreach (var item in list)
                    // {
                    //    Console.WriteLine(item);
                    // }

          //-------ArrayList Remove---------

              //  list.Remove("English");
              //  list.RemoveAt(3);
              //  list.RemoveRange(1, 2);
              // foreach (var item in list)
              //  {
              //     Console.WriteLine(item);
              //  }

          //-----------ArrayList Clear------------

                    // list.Clear();
                    // foreach (var item in list)
                    //  {
                    //    Console.WriteLine(item);
                    //  }

            //---------------ArrayList Contains----------

                   // Console.WriteLine(list.Contains("Urdu"));
                   Console.WriteLine(list.Contains("Sports"));


        }
    }
}
