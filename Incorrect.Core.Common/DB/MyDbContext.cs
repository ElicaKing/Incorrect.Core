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
        public virtual DbSet<BaseCityInfo> BaseCityInfo { get; set; }
        public virtual DbSet<BaseCounty_Info> BaseCounty_Info { get; set; }
        public virtual DbSet<BaseCourse_Info> BaseCourse_Info { get; set; }
        public virtual DbSet<BaseDifficultyInfo> BaseDifficultyInfo { get; set; }
        public virtual DbSet<BaseGrade_Info> BaseGrade_Info { get; set; }
        public virtual DbSet<BaseProvinceInfo> BaseProvinceInfo { get; set; }
        public virtual DbSet<Exam_Info> Exam_Info { get; set; }
        public virtual DbSet<ExamQuestion_Info> ExamQuestion_Info { get; set; }
        public virtual DbSet<Knowledge_Info> Knowledge_Info { get; set; }
        public virtual DbSet<Material_Info> Material_Info { get; set; }
        public virtual DbSet<MaterialChapter_Info> MaterialChapter_Info { get; set; }
        public virtual DbSet<MaterialQuestion_Info> MaterialQuestion_Info { get; set; }
        public virtual DbSet<MaterialUsed_Info> MaterialUsed_Info { get; set; }
        public virtual DbSet<OperateLog> OperateLog { get; set; }
        public virtual DbSet<PasswordLib> PasswordLib { get; set; }
        public virtual DbSet<QCard_Info> QCard_Info { get; set; }
        public virtual DbSet<QCardChapter_Info> QCardChapter_Info { get; set; }
        public virtual DbSet<QCardClass_Info> QCardClass_Info { get; set; }
        public virtual DbSet<QCardQuestion_Info> QCardQuestion_Info { get; set; }
        public virtual DbSet<QCardStudentRpt_Info> QCardStudentRpt_Info { get; set; }
        public virtual DbSet<QImportUploadFile_Info> QImportUploadFile_Info { get; set; }
        public virtual DbSet<QImportUploadFileDetail_Info> QImportUploadFileDetail_Info { get; set; }
        public virtual DbSet<Question_Info> Question_Info { get; set; }
        public virtual DbSet<QuestionAnswerUser_Info> QuestionAnswerUser_Info { get; set; }
        public virtual DbSet<QuestionCart_Info> QuestionCart_Info { get; set; }
        public virtual DbSet<QuestionEx_Info> QuestionEx_Info { get; set; }
        public virtual DbSet<QuestionFavorite_Info> QuestionFavorite_Info { get; set; }
        public virtual DbSet<QuestionImportEx> QuestionImportEx { get; set; }
        public virtual DbSet<QuestionKnowledge_Info> QuestionKnowledge_Info { get; set; }
        public virtual DbSet<QuestionOption_Info> QuestionOption_Info { get; set; }
        public virtual DbSet<QuestionOrganEx_Info> QuestionOrganEx_Info { get; set; }
        public virtual DbSet<QuestionPractice_Info> QuestionPractice_Info { get; set; }
        public virtual DbSet<QuestionStatistics_Info> QuestionStatistics_Info { get; set; }
        public virtual DbSet<SchoolClass_Info> SchoolClass_Info { get; set; }
        public virtual DbSet<SchoolClassType_Info> SchoolClassType_Info { get; set; }
        public virtual DbSet<SchoolCourse_Info> SchoolCourse_Info { get; set; }
        public virtual DbSet<SchoolGrade_Info> SchoolGrade_Info { get; set; }
        public virtual DbSet<SchoolUserRelation_Info> SchoolUserRelation_Info { get; set; }
        public virtual DbSet<Schoolyear_Info> Schoolyear_Info { get; set; }
        public virtual DbSet<SysBaseDetail_Info> SysBaseDetail_Info { get; set; }
        public virtual DbSet<SysBaseMain_Info> SysBaseMain_Info { get; set; }
        public virtual DbSet<SysDept_Info> SysDept_Info { get; set; }
        public virtual DbSet<SysDeptUser_Info> SysDeptUser_Info { get; set; }
        public virtual DbSet<SysFunc_Info> SysFunc_Info { get; set; }
        public virtual DbSet<SysFuncTemplate_Info> SysFuncTemplate_Info { get; set; }
        public virtual DbSet<SysModule_Info> SysModule_Info { get; set; }
        public virtual DbSet<SysModulePermission> SysModulePermission { get; set; }
        public virtual DbSet<SysOrgan_Info> SysOrgan_Info { get; set; }
        public virtual DbSet<SysOrganEx_Info> SysOrganEx_Info { get; set; }
        public virtual DbSet<SysOrganSchoolEx_Info> SysOrganSchoolEx_Info { get; set; }
        public virtual DbSet<SysOrganWeChatEx_Info> SysOrganWeChatEx_Info { get; set; }
        public virtual DbSet<SysPermission> SysPermission { get; set; }
        public virtual DbSet<SysPicToMathAppKey_Info> SysPicToMathAppKey_Info { get; set; }
        public virtual DbSet<SysPicToMathRecord_Info> SysPicToMathRecord_Info { get; set; }
        public virtual DbSet<SysPurviewTempate_Info> SysPurviewTempate_Info { get; set; }
        public virtual DbSet<SysPurviewTempateUser_Info> SysPurviewTempateUser_Info { get; set; }
        public virtual DbSet<SysRole_Info> SysRole_Info { get; set; }
        public virtual DbSet<SysRoleFunc_Info> SysRoleFunc_Info { get; set; }
        public virtual DbSet<SysRoleModulePermission> SysRoleModulePermission { get; set; }
        public virtual DbSet<SysUploadFile_Info> SysUploadFile_Info { get; set; }
        public virtual DbSet<SysUploadFileExt_Info> SysUploadFileExt_Info { get; set; }
        public virtual DbSet<SysUser_Info> SysUser_Info { get; set; }
        public virtual DbSet<SysUserBinding_Info> SysUserBinding_Info { get; set; }
        public virtual DbSet<SysUserCourse_Info> SysUserCourse_Info { get; set; }
        public virtual DbSet<SysUserEx_Info> SysUserEx_Info { get; set; }
        public virtual DbSet<SysUserFunc_Info> SysUserFunc_Info { get; set; }
        public virtual DbSet<SysUserFuncMenu_Info> SysUserFuncMenu_Info { get; set; }
        public virtual DbSet<SysUserFuncMenu_WebsiteEx_Info> SysUserFuncMenu_WebsiteEx_Info { get; set; }
        public virtual DbSet<SysUserFuncMenu_WeChatEx_Info> SysUserFuncMenu_WeChatEx_Info { get; set; }
        public virtual DbSet<SysUserRelation_Info> SysUserRelation_Info { get; set; }
        public virtual DbSet<SysUserRole_Info> SysUserRole_Info { get; set; }
        public virtual DbSet<SysWechatContact_Info> SysWechatContact_Info { get; set; }
        public virtual DbSet<tempStudentQcard_Info> tempStudentQcard_Info { get; set; }
        public virtual DbSet<ExamTestEx_Info> ExamTestEx_Info { get; set; }
        public virtual DbSet<QCardStudent_Info> QCardStudent_Info { get; set; }
        public virtual DbSet<QuestionComment> QuestionComment { get; set; }
        public virtual DbSet<v_BaseCourse_Info> v_BaseCourse_Info { get; set; }
        public virtual DbSet<v_BaseGrade_Info> v_BaseGrade_Info { get; set; }
        public virtual DbSet<v_Exam_Info> v_Exam_Info { get; set; }
        public virtual DbSet<v_ExamQuestion_Info> v_ExamQuestion_Info { get; set; }
        public virtual DbSet<v_Material_Info> v_Material_Info { get; set; }
        public virtual DbSet<v_MaterIalQuestion_Info> v_MaterIalQuestion_Info { get; set; }
        public virtual DbSet<v_MaterialUsed_Info> v_MaterialUsed_Info { get; set; }
        public virtual DbSet<v_QCard_Info> v_QCard_Info { get; set; }
        public virtual DbSet<v_QCardChapter_Info> v_QCardChapter_Info { get; set; }
        public virtual DbSet<v_QCardClass_Info> v_QCardClass_Info { get; set; }
        public virtual DbSet<v_QCardFullStudent_Info> v_QCardFullStudent_Info { get; set; }
        public virtual DbSet<v_QCardQuestion_Info> v_QCardQuestion_Info { get; set; }
        public virtual DbSet<v_QCardStudent_Info> v_QCardStudent_Info { get; set; }
        public virtual DbSet<v_QCardStudentRpt_Info> v_QCardStudentRpt_Info { get; set; }
        public virtual DbSet<v_Question_Info> v_Question_Info { get; set; }
        public virtual DbSet<v_QuestionAnswerUser_Info> v_QuestionAnswerUser_Info { get; set; }
        public virtual DbSet<v_QuestionKnowledge_Info> v_QuestionKnowledge_Info { get; set; }
        public virtual DbSet<v_QuestionPractice_Info> v_QuestionPractice_Info { get; set; }
        public virtual DbSet<v_SchoolClass_Info> v_SchoolClass_Info { get; set; }
        public virtual DbSet<v_SchoolClassType_Info> v_SchoolClassType_Info { get; set; }
        public virtual DbSet<v_SchoolCourse_Info> v_SchoolCourse_Info { get; set; }
        public virtual DbSet<v_SchoolGrade_Info> v_SchoolGrade_Info { get; set; }
        public virtual DbSet<v_SysOrgan_info> v_SysOrgan_info { get; set; }
        public virtual DbSet<v_SysPurviewTempateUser_Info> v_SysPurviewTempateUser_Info { get; set; }
        public virtual DbSet<v_SysRole_info> v_SysRole_info { get; set; }
        public virtual DbSet<v_SysUploadFile_Info> v_SysUploadFile_Info { get; set; }
        public virtual DbSet<v_SysUser_Info> v_SysUser_Info { get; set; }
        public virtual DbSet<v_SysUserBinding_Info> v_SysUserBinding_Info { get; set; }
        public virtual DbSet<v_SysUserClass_Info> v_SysUserClass_Info { get; set; }
        public virtual DbSet<v_SysUserCourse_Info> v_SysUserCourse_Info { get; set; }
        public virtual DbSet<v_SysUserFunc_Info> v_SysUserFunc_Info { get; set; }
        public virtual DbSet<v_SysUserFuncMenu_Info> v_SysUserFuncMenu_Info { get; set; }
        public virtual DbSet<v_SysUserFuncMenu_WebsiteInfo> v_SysUserFuncMenu_WebsiteInfo { get; set; }
        public virtual DbSet<v_SysUserFuncMenu_WeChatInfo> v_SysUserFuncMenu_WeChatInfo { get; set; }
        public virtual DbSet<v_SysUserGrade_Info> v_SysUserGrade_Info { get; set; }
        public virtual DbSet<v_SysUserRelation_Info> v_SysUserRelation_Info { get; set; }
    }
}
