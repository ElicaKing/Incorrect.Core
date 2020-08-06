using Incorrect.Core;
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
        #region DB实体库
        public virtual DbSet<Exam_Info> Exam_Info { get; set; }
        public virtual DbSet<SysUser_Info> SysUser_Info { get; set; }
        public virtual DbSet<SysOrgan_Info> SysOrgan_Info { get; set; }
        #endregion
        #region DB视图
        public virtual DbSet<v_Exam_Info> v_Exam_Info { get; set; }
        public virtual DbSet<v_SchoolGrade_Info> V_SchoolGrade_Info { get; set; }
        #endregion
    }
}
