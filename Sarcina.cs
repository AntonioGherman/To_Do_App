using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Sarcina
    {
       
        public string numeSarcina {
            set;get;
        }
        
        public string descriere {
            set; get;
        }
        
        public string dataFinalizare {

            set;get;
        }
        
        public string prioritate {
            set;get;
        }

        public Sarcina(string numeSarcina, string descriere, string dataFinalizare, string prioritate) {
            this.numeSarcina ="Nume sarcina: "+numeSarcina;
            this.descriere ="Descriere: "+ descriere;
            this.dataFinalizare ="Data de finalizare: "+ dataFinalizare;
            this.prioritate ="Nivel de prioritate: "+ prioritate;
        
        }

        public override string ToString()
        {
           

            return "Numele Sarcinii \r\n"+
                this.numeSarcina + "\r\nDescriere  \r\n" + 
                this.descriere + "\r\nData de finalizare \r\n" + 
                this.dataFinalizare + "\r\nNivelul de prioritate \r\n" +
                this.prioritate+ "\r\n\r\n";
        }


    }
}
