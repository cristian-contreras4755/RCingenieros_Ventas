using Modelo;
using Services.Procedimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GrupoService
    {

        public IEnumerable<object> ListarGrupo()
        {
            var listaClientes = new SP_ListarGrupo();
            try
            {
                using (var ctx = new DBContexto())
                {
                    var query = ctx.Database.SqlQuery<SP_ListarGrupo>("SP_ListarGrupo").ToList();
                    return query;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }







        public string RegistrarGrupo(Grupo grupo)
        {

            var status = "";

            try
            {
                using (var ctx = new DBContexto())
                {

                    ctx.Grupo.Add(grupo);
                    ctx.SaveChanges();
                    status = "OK";
                    return status;
                }


            }
            catch (Exception ex)
            {
                return status = Convert.ToString(ex);
            }
        }



        public string EditarGrupo(Grupo grupo)
        {
            var status = "";
            try
            {
                using (var bd = new DBContexto())
                {
                    bd.Entry(grupo).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                    status = "OK";
                }
            }
            catch (Exception ex)
            {
                status = "ERROR";
            }
            return status;
        }



        public string EliminarGrupo(int Id)
        {
            var estado = "";
            var grupo = new Grupo { IdGrupo = Id };
            try
            {
                using (var bd = new DBContexto())
                {

                    bd.Grupo.Attach(grupo);
                    grupo.Estado = "E";
                    bd.Configuration.ValidateOnSaveEnabled = false;
                    bd.SaveChanges();
                    estado = "OK";

                }
            }
            catch (Exception ex)
            {
                throw new Exception(estado = ex.Message);

            }
            return estado;
        }



    }
}
