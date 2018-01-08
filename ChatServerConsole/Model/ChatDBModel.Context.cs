﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatServerConsole.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ChatDBEntities : DbContext
    {
        public ChatDBEntities()
            : base("name=ChatDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_Group> C_Group { get; set; }
        public virtual DbSet<C_Group_Msg_Status> C_Group_Msg_Status { get; set; }
        public virtual DbSet<C_Group_User> C_Group_User { get; set; }
        public virtual DbSet<C_Msg_Type> C_Msg_Type { get; set; }
        public virtual DbSet<C_Multi_Msg> C_Multi_Msg { get; set; }
        public virtual DbSet<C_Single_Msg> C_Single_Msg { get; set; }
        public virtual DbSet<C_Status> C_Status { get; set; }
        public virtual DbSet<C_User> C_User { get; set; }
        public virtual DbSet<C_User_Type> C_User_Type { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<C_User_Status> C_User_Status { get; set; }
    
        public virtual ObjectResult<string> Register(string name, string password, string sex, string city, string userType, ObjectParameter userID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var sexParameter = sex != null ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("userType", userType) :
                new ObjectParameter("userType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Register", nameParameter, passwordParameter, sexParameter, cityParameter, userTypeParameter, userID);
        }
    
        public virtual ObjectResult<UserRegister_Result> UserRegister(string name, string password, string sex, string city, string userType, ObjectParameter userID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var sexParameter = sex != null ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("userType", userType) :
                new ObjectParameter("userType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserRegister_Result>("UserRegister", nameParameter, passwordParameter, sexParameter, cityParameter, userTypeParameter, userID);
        }
    
        public virtual ObjectResult<Nullable<int>> Login(string name, string password, string ip, Nullable<int> port)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var ipParameter = ip != null ?
                new ObjectParameter("ip", ip) :
                new ObjectParameter("ip", typeof(string));
    
            var portParameter = port.HasValue ?
                new ObjectParameter("port", port) :
                new ObjectParameter("port", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Login", nameParameter, passwordParameter, ipParameter, portParameter);
        }
    }
}