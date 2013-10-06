﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_frba.CapaNegocio
{
    class AdministrativoTM : TableModule
    {
        CapaDatos.AdministrativoTDG admTDG;
        
        // Constructor 
        public AdministrativoTM() { admTDG = new CapaDatos.AdministrativoTDG(); }

        
        // Métodos
        public DataSet getAdmById(int id)
        {
            DataSet adm = admTDG.getAdmById(id);
            return adm;
        }


        public DataSet getAdmByAtributos() { return new DataSet(); }
       
        
        
        public void insert() {}
        


        public void update() {
            DataTable adm = new DataTable();

            // Algún código obteniendo datos y metiendolos dentro del DataTable (es un objeto como cualquier otro)

            admTDG.update(adm); // actualizo los datos      
        }


        public void delete() {} 
    }
}