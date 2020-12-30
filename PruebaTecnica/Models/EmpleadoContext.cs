using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class EmpleadoContext:DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Habilidad> Habilidades { get; set; }

        public EmpleadoContext(DbContextOptions<EmpleadoContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var empleado = new Empleado();
            empleado.Id = 10;
            empleado.NombreCompleto = "Jorge Villanueva";
            empleado.FechaNacimiento = new DateTime();
            empleado.Correo = "correo@correo.com";
            empleado.FechaIngreso = new DateTime();
            empleado.Cedula = "6TG5TU-6";

            var list = new List<Empleado>();
            list.Add(empleado);
            list.Add(empleado);
            list.Add(empleado);

            modelBuilder.Entity<Empleado>().HasData(empleado);
        }
    }
}
