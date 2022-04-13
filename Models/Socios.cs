namespace CapaPresentacion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Socios
    {
        [Key]
        public int IdSocio { get; set; }

        [Required]
        public string NombreSocio { get; set; }

        [Required]
        [StringLength(13)]
        public string CedulaSocio { get; set; }

        internal object Agregar()
        {
            throw new NotImplementedException();
        }

        [Required]
        public string Direccion { get; set; }

        [Required]
        [StringLength(12)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(15)]
        public string TipoMembresia { get; set; }

        [Required]
        public string NombreContacto { get; set; }

        [Required]
        [StringLength(12)]
        public string TelefonoContacto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MembresiaEmitida { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PagarAntesDe { get; set; }

        public List<Socios> Listado( )
        {
            var socio = new List<Socios>();
            string cadena = ("Select * FROM Socios ");
            try
            {
                using (var contenedor = new BDProyecto())
                {
                    socio = contenedor.Database.SqlQuery<Socios>(cadena).ToList();
                }
            }
            catch (Exception)
            {
              //throw;
            }
            return socio;

        }
        public Boolean Agregar(string nom, string ced, string dir, string tel, string tipo, string contactoname, string telcontacto)
        {

            bool estado = false;
            string cadena = "'" + nom + "',";
            cadena += "'" + ced + "',";
            cadena += "'" + dir + "',";
            cadena += "' " + tel + "',";
            cadena += "'" + tipo + "',";
            cadena += "'" + contactoname + "',";
            cadena += "'" + telcontacto + "'";



            try
            {
                using (var cnx = new BDProyecto())
                {
                    int r = cnx.Database.ExecuteSqlCommand("Insert INTO Socios (NombreSocio, CedulaSocio, Direccion, Telefono, TipoMembresia, NombreContacto, TelefonoContacto)  VALUES (" + cadena + ")");
                    if (r == 1)
                    {
                        estado = true;
                    }
                }
            }
            catch (Exception)
            {
                estado = false;

            }
            return estado;
        }
        public Socios un_registro(int id)
        {
            var registro = new Socios();
            try
            {
                using (var cnx = new BDProyecto())
                {
                    registro = cnx.Socios.Where(a => a.IdSocio == id).Single();
                }
            }
            catch (Exception)
            {

                // throw;
            }
            return registro;
        }
        public Boolean Editar(int id, string nom, string ced, string dir, string tel, string tipo, string contactoname, string telcontacto)
        {
            bool estado = false;
            string cadena = "NombreSocio='" + nom + "', CedulaSocio='" + ced + "', Direccion'" + dir + "', Telefono'" + tel + "', TipoMembresia'" + tipo + "', NombreContacto'" + contactoname + "', TelefonoContacto='" + telcontacto + "' WHERE IdSocio=" + id;

            try
            {
                using (var cnx = new BDProyecto())
                {

                    int r = cnx.Database.ExecuteSqlCommand("UPDATE Socios SET " + cadena);
                    if (r == 1)
                    {
                        estado = true;
                    }
                }
            }
            catch (Exception)
            {
                estado = false;
                //throw;
            }
            return estado;
        }
        public Boolean Eliminar(int id)
        {
            bool estado = false;
            try
            {

                using (var cnx = new BDProyecto())
                {
                    int r = cnx.Database.ExecuteSqlCommand("DELETE FROM Socios WHERE IdSocio=" + id);
                    if (r == 1)
                    {
                        estado = true;
                    }
                }
            }
            catch (Exception)
            {
                estado = false;

            }
            return estado;
        }
    }
}
