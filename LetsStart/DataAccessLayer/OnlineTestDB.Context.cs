﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnlineTestDBEntities : DbContext
    {
        public OnlineTestDBEntities()
            : base("name=OnlineTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblAnswer> tblAnswers { get; set; }
        public DbSet<tblGroupMember> tblGroupMembers { get; set; }
        public DbSet<tblGroup> tblGroups { get; set; }
        public DbSet<tblQuestionAnswer> tblQuestionAnswers { get; set; }
        public DbSet<tblQuestion> tblQuestions { get; set; }
        public DbSet<tblQuestionSubject> tblQuestionSubjects { get; set; }
        public DbSet<tblSubject> tblSubjects { get; set; }
        public DbSet<tblTestQuestion> tblTestQuestions { get; set; }
        public DbSet<tblTest> tblTests { get; set; }
        public DbSet<tblTestUserQuestion> tblTestUserQuestions { get; set; }
        public DbSet<tblTestUser> tblTestUsers { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblUserType> tblUserTypes { get; set; }
        public DbSet<tblMenu> tblMenus { get; set; }
    }
}