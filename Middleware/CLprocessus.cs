using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    class CLprocessus
    {
        private Dataset oDs;
        private CLmapTB_A2_WS2 oMap;
        private CLcad oCad;
        private String rq_sql;

        public CAO()
        {
            //constructeur par défaut qui initialisera les privates.
            this.Dataset oDs = null;
            this.rq_sql = "";
            this.oMap = new.oMap;
            this.oCad = new.oCad;


        }

        DataSet afficher(string dataTableName)
        {

            this.DataSet();
            return this.DoDs;
        }

        DataSet rechercherNom(string dataTableName, string nom)
        {
            this.oMap.selectByName();
        }
        void deleteById()
        {

        }
        void insert_update(int id, string nom, string prenom, char methode)
        {

        }
    }
}


