using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ROT13
{

    internal class Decoder:Program
    {
        public string Rot13(string eingabe)
        {
              


            string Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            eingabe = eingabe.ToUpper();
            var result = "";

            for (int i = 0; i < eingabe.Length; i++)
            {
                var c = eingabe[i];

                var index = Alpha.IndexOf(c.ToString());

                index = (index + 13) % Alpha.Length;

                var zw = Alpha.Substring(index, 1);
                result = result + zw;

            }
            
            

            return result;


        }

        public string Rot47(string eingabe)
        {
            string Alpha = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";



            var result = "";

            for (int i = 0; i < eingabe.Length; i++)
            {
                var c = eingabe[i];

                var index = Alpha.IndexOf(c.ToString());


                if (index == -1) continue; 
                    index = (index + 47) % Alpha.Length;
                
                
                    
                

                var zw = Alpha.Substring(index, 1);

                result = result + zw;

            }
           
           

            return result;

        }


    }



}
