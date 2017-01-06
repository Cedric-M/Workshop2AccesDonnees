using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added the next ones :
using System.Data.SqlClient;
using System.Data;

namespace CAD
{
    public class CLcad
    {
        private String cnx;
        private String rq_sql;
        private SqlDataAdapter DataAdapter;
        private SqlConnection Connection;
        private SqlCommand Command;
        private DataSet DataSet;

        public CLcad()
        {
            //constructeur par défaut qui initialisera les privates.
            this.cnx = "Data Source=ODB;Initial Catalog=msdb;Integrated Security=True";
            this.rq_sql = "";
            this.Connection = new SqlConnection(this.cnx);
            this.Command = null;
            this.DataAdapter = null;
            this.DataSet = new DataSet();

        }
        public void actionRows(String rq_sql) //Query
        //méthode public void actionRows(string rq_sql). 
        //Cette méthode exécutera les requêtes actions SQL (insert – update – delete).

        {
            this.rq_sql = rq_sql;
            this.Command = new SqlCommand(rq_sql, Connection);
            this.Connection.Open();
            this.Command.ExecuteNonQuery();
            this.Connection.Close();
        }
        public DataSet getRows(string rq_sql, string dataTableName) //Non-Query
        {
            //Cette méthode se chargera d’exécuter les requêtes de type récupération de données.
            this.rq_sql = rq_sql;
            this.DataSet = new DataSet();
            this.Command = new SqlCommand(rq_sql, Connection);
            this.DataAdapter = new SqlDataAdapter(Command);
            this.DataAdapter.Fill(DataSet, "Rows");
            return this.DataSet;
        }
      /*  Memo Ws :
       *  String cnx : la chaine de connexion à la base de données.
        o String rq_sql : le variable qui contiendra toutes les instructions SQL.
        o SqlDataAdapter (pour SQL Server) : le lien logique entre le niveau applicatif et la base de données.
        o SqlConnection : L’objet encapsulant les informations de connexion à la base de données.
        o SqlCommand : L’objet encapsulant les informations nécessaires à l’exécution de la commande SQL.
        o DataSet : le cache qui contiendra les données manipulables par l’interface graphique en mode déconnecté. 
       */
    }
}