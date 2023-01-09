using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace First_Checkpoint.Data
{
    public class First_CheckpointContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public First_CheckpointContext() : base("name=First_CheckpointContext")
        {
        }
        
        public System.Data.Entity.DbSet<First_Checkpoint.Models.Admin> Admins { get; set; }
        public System.Data.Entity.DbSet<First_Checkpoint.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<First_Checkpoint.Models.Post> Posts { get; set; }
        
        public System.Data.Entity.DbSet<First_Checkpoint.Models.Product> Products { get; set; }
        public System.Data.Entity.DbSet<First_Checkpoint.Models.Review> Reviews { get; set; }
        public System.Data.Entity.DbSet<First_Checkpoint.Models.Category> Categories { get; set; }
        public System.Data.Entity.DbSet<First_Checkpoint.Models.Chat> Chats { get; set; }

        public System.Data.Entity.DbSet<First_Checkpoint.Models.Membership> Memberships { get; set; }

        public System.Data.Entity.DbSet<First_Checkpoint.Models.LogIn> LogIns { get; set; }
    }
}
