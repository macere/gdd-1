﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_frba.CapaDatos
{
    class TurnosTDG : TableDataGateway
    {
        public void insert(DataRow turno) { }
        public void update(DataTable turno) { }
        public void delete(DataRow turno) { }
        public DataSet getTurnosById(int id) { return new DataSet(); }
    }
}
