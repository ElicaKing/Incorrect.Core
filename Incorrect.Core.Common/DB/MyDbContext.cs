using Incorrect.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Incorrect.Core.Common
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Exam_Info> Exam_Info { get; set; }
        public virtual DbSet<v_Exam_Info> v_Exam_Info { get; set; }
        public virtual DbSet<v_SchoolGrade_Info> V_SchoolGrade_Info { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Query<v_SchoolGrade_Info>().ToView("v_SchoolGrade_Info");
        //    modelBuilder.Query<v_Exam_Info>().ToView("v_Exam_Info");
        //}
    }
}
