using System;
using System.Collections.Generic;
using System.Text;
using BackendAcademico.Core.Entities;
using BackendAcademico.Core.Interfaces;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Extensions.Configuration;

namespace BackendAcademico.Infraestructure.Repositories
{
    public class MateriaRepository: IMateriaRepository
    {
        private readonly IConfiguration _configuration;
        public MateriaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IEnumerable<Materia> GetMaterias()
        {
            string strCon = _configuration.GetConnectionString("OracleDBConnection");
            List<Materia> listMat = new List<Materia>();
            using (OracleConnection connection = new OracleConnection(strCon))
            {
                using (OracleCommand command = connection.CreateCommand())
                {
                    try
                    {
                        connection.Open();
                        command.CommandText = "select * from materia";
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            listMat.Add(new Materia()
                            {
                                IdMateria = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Sigla = reader.GetString(2),
                            });
                        }
                        reader.Dispose();
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }
                }
            }
            return listMat;
        }
    }
}
