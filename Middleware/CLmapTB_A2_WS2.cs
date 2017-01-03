using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class CLmapTB_A2_WS2
    {
        String rq_sql;
        private String nom;
        private String prenom;
        private int ID;

        public String selectall()
        {
            this.rq_sql = "SELECT * FROM [DB_A2_WS2].[dbo].[TB_A2_WS2]";
            return rq_sql;
        }
        /*méthode string selectAll() qui renverra une chaine de caractères.Cette chaine sera la requête SQL 
            pour sélectionner tous les enregistrements de la table.*/
        public String selectbyName()
        {
            this.rq_sql = "SELECT * FROM [DB_A2_WS2].[dbo].[TB_A2_WS2] WHERE nom = '" + this.nom + "'";
            return rq_sql;
        }
        /*méthode string selectAll() qui renverra une chaine de caractères. Cette chaine sera la requête SQL 
         * pour sélectionner tous les enregistrements de la table.*/
        public String delete()
        {
            this.rq_sql = "DELETE FROM TB_A2_WS2 WHERE id = " + this.ID + ";";
            return rq_sql;
        }
        /*méthode string delete()qui renverra une chaine de caractères. Cette chaine sera la requête SQL 
         * pour supprimer tous les enregistrements de la table répondant au critère id = param.*/
        public String insert()
        {
            this.rq_sql = "INSERT INTO TB_A2_WS2 ([nom], [prenom]) VALUES nom = '" + this.nom + "' , prenom = '" + this.prenom + "');";
            return rq_sql;
        }
        /*méthode string insert()qui renverra une chaine de caractères. Cette chaine sera la requête SQL 
         * pour ajouter un enregistrement.*/
        public String update()
        {
            rq_sql = "UPDATE [DB_A2_WS2].[dbo].[TB_A2_WS2] SET ([nom] , [prenom]) ='" + this.nom + "' , '" + this.prenom + "' WHERE id = " + this.ID + " ;";
            return rq_sql;
        }
        /*méthode string update()qui renverra une chaine de caractères. Cette chaine sera la requête SQL 
         * pour mettre à jour un enregistrement.*/


        //accesseurs pour id, nom, prénom :

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }



    }
}