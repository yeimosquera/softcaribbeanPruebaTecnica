using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using softcaribbean.Data;
using softcaribbeanPruebaTecnica.Model;
using Dapper;


namespace softcaribbeanPruebaTecnica.Data.Repositories
{
    public class PersonasRepository : IPersonaRepository
    {
        private MySQLConfig _connectionString;
        public PersonasRepository(MySQLConfig connectionString)
        {
            _connectionString = connectionString;

        }

        protected MySqlConnection dbConection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }


        public async Task<IEnumerable<Persona>> GetPersonasPacientes(int tipoPerson)
        {
            var db = dbConection();
            var sql = @" SELECT id, cddocumento, dsnombres, dsapellidos, fenacimiento, cdgenero, 
                         feregistro, febaja, cdusuario, dsdireccion, dsphoto, cdtelefono_fijo, 
                         cdtelefono_movil, dsemail, dseps, dsarl, dscondicion, cdtipo 
                         FROM persona
                         WHERE cdtipo = @TipoPerson";
            return await db.QueryAsync<Persona>(sql, new { TipoPerson = tipoPerson });
        }

        public async Task<Persona> GetDetallePersonas(int id)
        {
            var db = dbConection();
            var sql = @" SELECT id, cddocumento, dsnombres, dsapellidos, fenacimiento, cdgenero, 
                         feregistro, febaja, cdusuario, dsdireccion, dsphoto, cdtelefono_fijo, 
                         cdtelefono_movil, dsemail, dseps, dsarl, dscondicion, cdtipo 
                         FROM persona
                         WHERE id = @Id";
            return await db.QueryFirstOrDefaultAsync<Persona>(sql, new { Id = id });
        }

        public async Task<bool> InsertPersonas(Persona persona)
        {
            var db = dbConection();
            var sql = @" INSERT INTO persona (
                            cddocumento, 
                            dsnombres, 
                            dsapellidos, 
                            fenacimiento, 
                            cdgenero, 
                            feregistro, 
                            febaja, 
                            cdusuario, 
                            dsdireccion, 
                            dsphoto, 
                            cdtelefono_fijo, 
                            cdtelefono_movil, 
                            dsemail, 
                            dseps, 
                            dsarl, 
                            dscondicion, 
                            cdtipo
                        )
                        VALUES(
                            @Cddocumento, 
                            @Dsnombres, 
                            @Dsapellidos, 
                            @fenacimiento, 
                            @cdgenero, 
                            @Feregistro, 
                            @Febaja, 
                            @Cdusuario, 
                            @Dsdireccion, 
                            @Dsphoto, 
                            @Cdtelefono_Fijo, 
                            @Cdtelefono_Movil, 
                            @Dsemail, 
                            @Dseps, 
                            @Dsarl, 
                            @Dscondicion, 
                            @Cdtipo
                        )
                         ";
            var result = await db.ExecuteAsync(sql, new
            {
                persona.Cddocumento,
                persona.Dsnombres,
                persona.Dsapellidos,
                persona.Fenacimiento,
                persona.Cdgenero,
                persona.Feregistro,
                persona.Febaja,
                persona.Cdusuario,
                persona.Dsdireccion,
                persona.Dsphoto,
                persona.Cdtelefono_Fijo,
                persona.Cdtelefono_Movil,
                persona.Dsemail,
                persona.Dseps,
                persona.Dsarl,
                persona.Dscondicion,
                persona.Cdtipo
            });
            return result > 0;
        }

        public async Task<bool> UpdatePersonas(Persona persona)
        {
            var db = dbConection();
            var sql = @" UPDATE persona 
                         SET
                            cddocumento = @Cddocumento, 
                            dsnombres = @Dsnombres, 
                            dsapellidos = @Dsapellidos, 
                            fenacimiento = @fenacimiento, 
                            cdgenero = @cdgenero, 
                            feregistro = @Feregistro, 
                            febaja = @Febaja, 
                            cdusuario = @Cdusuario, 
                            dsdireccion = @Dsdireccion, 
                            dsphoto = @Dsphoto, 
                            cdtelefono_fijo = @Cdtelefono_Fijo, 
                            cdtelefono_movil = @Cdtelefono_Movil, 
                            dsemail = @Dsemail, 
                            dseps = @Dseps, 
                            dsarl = @Dsarl, 
                            dscondicion = @Dscondicion, 
                            cdtipo = @Cdtipo
                        WHERE id = @Id
                        
                         ";
            var result = await db.ExecuteAsync(sql, new {persona.Cddocumento, persona.Dsnombres,persona.Dsapellidos,
                                                        persona.Fenacimiento, persona.Cdgenero,persona.Feregistro,
                                                        persona.Febaja, persona.Cdusuario, persona.Dsdireccion,
                                                        persona.Dsphoto, persona.Cdtelefono_Fijo,persona.Cdtelefono_Movil,
                                                        persona.Dsemail, persona.Dseps, persona.Dsarl, persona.Dscondicion,
                                                        persona.Cdtipo, persona.Id});
            return result > 0;
        }

        public async Task<bool> DeletePersonas(Persona persona)
        {
            var db = dbConection();
            var sql = @" DELETE FROM persona WHERE id = @Id";
            var result = await db.ExecuteAsync(sql, new { Id = persona.Id });
            return result > 0;
        }

        public async Task<IEnumerable<Persona>> GetAllPersonas()
        {
            var db = dbConection();
            var sql = @" SELECT id, cddocumento, dsnombres, dsapellidos, fenacimiento, cdgenero, 
                         feregistro, febaja, cdusuario, dsdireccion, dsphoto, cdtelefono_fijo, 
                         cdtelefono_movil, dsemail, dseps, dsarl, dscondicion, cdtipo 
                         FROM persona ";
            return await db.QueryAsync<Persona>(sql, new {});
        }

        
    }
}
