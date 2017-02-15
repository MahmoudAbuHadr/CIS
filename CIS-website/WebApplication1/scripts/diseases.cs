using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class diseases
    {
        int id;
        bool anemia;
        bool asthma;
        bool epilipsy;
        bool depression;
        bool diabetes;
        bool diarrhea;
        bool heartAttack;
        bool hepatitis;
        bool rheumatism;
        bool scarletFever;
        bool std;
        

        public diseases() { }
       public diseases(int ID , bool Anemia ,bool Asthma , bool Epi , bool Depression , bool diab,
                       bool Diarrhea , bool HeartAttack ,bool Hepatitis , bool Rheuma , bool Scarlet ,bool STD)
           
        {
            id = ID;
            hepatitis = Hepatitis;
            std = STD;
            heartAttack = HeartAttack;
            depression = Depression;
            anemia = Anemia;
            epilipsy = Epi;
            diabetes = diab;
            diarrhea = Diarrhea;
            rheumatism = Rheuma;
            scarletFever = Scarlet;
            asthma = Asthma;

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