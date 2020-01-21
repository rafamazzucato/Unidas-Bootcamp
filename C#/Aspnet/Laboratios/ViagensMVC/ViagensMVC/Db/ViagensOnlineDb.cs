using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ViagensMVC.Models;

namespace ViagensMVC.Db
{
    public class ViagensOnlineDb : DbContext
    {
        private const string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafael\Desktop\Unidas Jan20\Unidas-Bootcamp\Unidas-Bootcamp\C#\Aspnet\Laboratios\ViagensMVC\ViagensMVC\App_Data\ViagensMvcDb.mdf;Integrated Security=True";

        public ViagensOnlineDb() : base(conexao)
        {
        }

        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}