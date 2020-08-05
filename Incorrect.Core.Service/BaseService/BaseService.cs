using Incorrect.Core.IRespository;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Incorrect.Core.Service
{
    public class BaseService<T> where T : class, new()
    {
        protected IUnitOfWork unitOfWork;
        protected IBaseRepository<T> currentRepository;

        public BaseService(IUnitOfWork unitOfWork, IBaseRepository<T> currentRepository)
        {
            this.unitOfWork = unitOfWork;
            this.currentRepository = currentRepository;
        }
        public async ValueTask<EntityEntry<T>> Insert(T entity)
        {
            
            return await currentRepository.Insert(entity);
        }

        public void Update(T entity)
        {
           currentRepository.Update(entity);
        }

        public async Task<int> Update(Expression<Func<T, bool>> whereLambda, Expression<Func<T, T>> entity)
        {
            
            return await currentRepository.Update(whereLambda, entity);
        }

        public async Task<int> Delete(Expression<Func<T, bool>> whereLambda)
        {
            await currentRepository.Delete(whereLambda);
            return await unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> IsExist(Expression<Func<T, bool>> whereLambda)
        {
            return await currentRepository.IsExist(whereLambda);
        }

        public async Task<T> GetEntity(Expression<Func<T, bool>> whereLambda)
        {
            return await currentRepository.GetEntity(whereLambda);
        }

        public async Task<List<T>> Select()
        {
            return await currentRepository.Select();
        }

        public async Task<List<T>> Select(Expression<Func<T, bool>> whereLambda)
        {
            return await currentRepository.Select(whereLambda);
        }

        public async Task<Tuple<List<T>, int>> Select<S>(int pageSize, int pageIndex, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc)
        {
            return await currentRepository.Select(pageSize, pageIndex, whereLambda, orderByLambda, isAsc);

        }
        /// <summary>  
        /// 根据模型删除数据
        /// </summary>  
        /// <param name="model">该模型对象必须包含id值</param>  
        /// <returns>返回受影响的行数</returns>  
        public async Task<int> Delete(T model)
        {

            return await currentRepository.Delete(model);
        }
            /// <summary>  
            /// 批量新增实体
            /// </summary>  
            /// <typeparam name="T">泛型类型参数</typeparam>  
            /// <param name="entityList">待添加的实体集合</param>  
            /// <returns></returns>  
            public async Task<int> AddRange(List<T> entityList)
        {
            return await currentRepository.AddRange(entityList);
        }
        /// <summary>
        /// 普通批量插入
        /// </summary>
        /// <param name="datas">true or false</param>
        public async Task<bool> AddRangeTransaction(List<T> datas)
        {
            using (TransactionScope Ts = new TransactionScope(TransactionScopeOption.Required))
            {
                currentRepository.AddRange(datas);
                int Count = await unitOfWork.SaveChangesAsync();
                Ts.Complete();
                return Count > 0;
            }
        }
        /// <summary>
        /// 获取查询条件的数据总条数 （支持多条件查询）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public int GetCount(Expression<Func<T, bool>> whereLambda = null)
        {
            return whereLambda != null ? currentRepository.GetCount(whereLambda) : currentRepository.GetCount();
        }

        /// <summary>
        /// 判断对象是否存在 （支持多条件查询）
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns>对象存在则返回true，不存在则返回false</returns>
        public bool GetAny(Expression<Func<T, bool>> whereLambda = null)
        {
            return whereLambda != null ? currentRepository.GetAny(whereLambda) : currentRepository.GetAny();
        }
        /// <summary>  
        /// 获取数据集合 (支持多条件查询) 
        /// </summary>  
        /// <param name="whereLambda"></param>  
        /// <returns></returns>  
        public IQueryable<T> GetList(Expression<Func<T, bool>> whereLambda)
        {
            return currentRepository.GetList(whereLambda);

        }
        /// <summary>  
        ///  获取数据集合 （支持多条件查询，仅支持单条件排序）
        /// </summary>  
        /// <typeparam name="TKey"></typeparam>  
        /// <param name="whereLambda"></param>  
        /// <param name="orderLambda"></param>  
        /// <param name="isAsc">是否为升序排序，默认为true</param>  
        /// <returns></returns>  
        public IQueryable<T> GetList<TKey>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderByLambda, bool isAsc = true)
        {
            
            IQueryable<T> QueryList = isAsc == true ? currentRepository.GetList(whereLambda).OrderBy(orderByLambda) : currentRepository.GetList(whereLambda).OrderByDescending(orderByLambda);
            if (whereLambda != null)
            {
                QueryList = QueryList.Where(whereLambda);
            }
            return QueryList;

        }
        /// <summary>
        /// 分页查询 ,带输出数据总条数 （支持多条件查询，仅支持单列排序）
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页显示数据的条数</param>
        /// <param name="totalCount">数据总条数</param>
        /// <param name="orderByLambda">排序条件</param>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="isAsc">是否为升序排序，默认为true</param>
        /// <returns></returns>
        public IQueryable<T> GetPagedList<TKey>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, TKey>> orderByLambda, Expression<Func<T, bool>> whereLambda = null, bool isAsc = true)
        {
            
            //分页的时候一定要注意 Order一定在Skip 之前
            IQueryable<T> QueryList = isAsc == true ? currentRepository.GetList(whereLambda).OrderBy(orderByLambda) : currentRepository.GetList(whereLambda).OrderByDescending(orderByLambda);
            if (whereLambda != null)
            {
                QueryList = QueryList.Where(whereLambda);
            }
            totalCount = QueryList.Count();
            return QueryList.Skip(pageSize * (pageIndex - 1)).Take(pageSize);


        }
        ///// <summary>
        ///// 执行存储过程的SQL 语句
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="Sql">执行的SQL语句</param>
        ///// <param name="Parms">SQL 语句的参数</param>
        ///// <param name="CmdType"> SQL命令（默认为Text）</param>
        ///// <returns></returns>
        //public IQueryable<T> ProQuery(string Sql, List<SqlParameter> Parms, CommandType CmdType = CommandType.Text)
        //{
        //    //进行执行存储过程
        //    if (CmdType == CommandType.StoredProcedure)
        //    {
        //        StringBuilder paraNames = new StringBuilder();
        //        foreach (var item in Parms)
        //        {
        //            paraNames.Append($" @{item},");
        //        }
        //        Sql = paraNames.Length > 0 ? $"exec {Sql} {paraNames.ToString().Trim(',')}" : $"exec {Sql} ";
        //    }
        //    return myDbContext.Set<T>().query(Sql, Parms.ToArray()).AsQueryable();
        //}
        /// <summary>
        /// 创建一个原始 SQL 用户 新增，删除，编辑
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns>返回受影响的行数</returns>
        public int ExecuteSqlCommand(string sql, params SqlParameter[] parameters)
        {
            
            return currentRepository.ExecuteSqlCommand(sql, parameters);

        }
        /// <summary>  
        /// 获取带 in 的sql参数列表  
        /// </summary>  
        /// <param name="sql">带in ( {0} )的sql</param>  
        /// <param name="ids">以逗号分隔的id字符串</param>  
        /// <returns>sql参数列表</returns>  
        public SqlParameter[] GetWithInSqlParameters(ref string sql, string ids)
        {
            if (string.IsNullOrEmpty(ids))
            {
                return null;
            }
            string[] idArr = ids.Split(',');
            //组建sql在in中的字符串  
            StringBuilder sbCondition = new StringBuilder();
            List<SqlParameter> spList = new List<SqlParameter>();
            for (int i = 0; i < idArr.Length; i++)
            {
                string id = idArr[i];
                sbCondition.Append("@id" + i + ",");
                spList.Add(new SqlParameter("@id" + i.ToString(), id));
            }
            //重新构建sql  
            sql = string.Format(sql, sbCondition.ToString().TrimEnd(','));
            return spList.ToArray();
        }
    }
}
