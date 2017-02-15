using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class diseases
    {
        int id;
        bool hepatitis;
        bool rheumatism;
        bool std;
        bool heartAttack;
        bool depression;

        public diseases() { }
       public diseases(int ID , bool Hepatitis ,bool Rheumatism , bool Std , bool HeartAttack , bool Depression)
        {
            id = ID;
            hepatitis = Hepatitis;
            rheumatism = Rheumatism;
            std = Std;
            heartAttack = HeartAttack;
            depression = Depression;
        }

       public  void setId(int ID) { id = ID; }
       public int getId() { return id; }

        public void setHepatitis(bool hep) { hepatitis = hep; }
        public bool getHepatitis() { return hepatitis; }

        public void setRheumatism(bool rheu) { rheumatism = rheu; }
        public bool getRheumatism() { return rheumatism; }

        public void setStd(bool STD) { std = STD; }
        public bool getSTD() { return std; }

        public void setHeartAttack(bool heart) { heartAttack = heart; }
        public bool getHeartAttack() { return heartAttack; }

        public void setDepression(bool dep) { depression = dep; }
        public bool getDepression() { return depression; }
    }
}