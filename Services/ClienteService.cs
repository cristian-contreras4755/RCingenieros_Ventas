using Modelo;
using Services.Procedimientos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace Services
{
  public  class ClienteService
    {


        public IEnumerable<object> ListarTotalDeClientes()
        {
            var listaClientes = new SP_ListarTodosClientes();

            try
            {

                using (var ctx = new DBContexto())
                {
                    var query = ctx.Database.SqlQuery<SP_ListarTodosClientes>("SP_ListarTodosClientes").ToList();
                    return query;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }







        public IEnumerable<SP_ListarClientesPorEmpleado> ListarClientesPorEmpleado(int IdEmpleado)
        {
            try
            {

           using (var ctx = new DBContexto())
            {
                var query = ctx.Database.SqlQuery<SP_ListarClientesPorEmpleado>("SP_ListarClientesPorEmpleado @IdEmpleado", new SqlParameter("@IdEmpleado", IdEmpleado)).ToList();
                return query;
            }

            }
            catch (Exception)
            {

                throw;
            }

 
        }


        public SP_ObtenerClientePorId ObtenerClientePorId(int Idcliente)
        {
            try
            {

                using (var ctx = new DBContexto())
                {
                    var query = ctx.Database.SqlQuery<SP_ObtenerClientePorId>("SP_ObtenerClientePorId @Idcliente", new SqlParameter("@Idcliente", Idcliente)).FirstOrDefault();
                    return query;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }









        public string RegistrarCliente(Cliente cliente) {

            var status = "";

            try
            {
                using (var ctx=new DBContexto()) {

                    ctx.Cliente.Add(cliente);
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



        public string EditarCliente(Cliente cliente)
        {
            var status = "";
            try
            {
                using (var bd = new DBContexto())
                {
                bd.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
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



        public string EliminarCliente(int Id)
        {
            var estado = "";
            var cliente = new Cliente { Idcliente = Id };
            try
            {
                using (var bd = new DBContexto())
                {

                    bd.Cliente.Attach(cliente);
                    cliente.Estado = "E";
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
