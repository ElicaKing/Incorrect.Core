using AutoMapper;
using Incorrect.Core.Common;
using Incorrect.Core.IRespository;
using Incorrect.Core.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Incorrect.Core.Service
{
    public class SysUserInfoService : BaseService<SysUser_Info>, ISysUserInfoService
    {
        public ISysOrganInfoRespository _sysOrganInfo;
        IMapper _mapper;
        public MyDbContext _dbContext;
        public SysUserInfoService(IUnitOfWork unitOfWork, IBaseRepository<SysUser_Info> currentRepository, ISysOrganInfoRespository sysOrganInfo,MyDbContext dbContext, IMapper mapper) : base(unitOfWork, currentRepository)
        {
            this._sysOrganInfo = sysOrganInfo;
            this._dbContext = dbContext;
            this._mapper = mapper;
        }
        public async Task<SysUser_Info> getUserInfo(string LoginCode, string Password)
        {
            var userInfo = await currentRepository.FirstOrDefault(c => c.LoginCode.Equals(LoginCode) && c.Password.Equals(Password) && c.Status.Equals(0));
            SysUser_Info _Info = null;
            if (userInfo != null)
            {
                _Info = _mapper.Map<SysUser_Info>(userInfo);
            }
            return _Info;
        }

        public Task<SysUser_Info> UpdateUser(SysUser_Info user_Info)
        {
            throw new NotImplementedException();
        }

        public Task<SysUser_Info> InsertUser(SysUser_Info user_Info)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SysUser_Info> getUsers()
        {
            return _dbContext.SysUser_Info.AsQueryable();
        }

        public async Task<List<SysUser_Info>>  GetUserById(int id)
        {
            if (id > 0) return await currentRepository.Find(c=>c.ID.Equals(id));
            else return null;
        }
    }
}
