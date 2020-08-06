using Incorrect.Core.IRespository;
using Incorrect.Core.IService;
using System;
using System.Threading.Tasks;

namespace Incorrect.Core.Service
{
    public class SysUserInfoService : BaseService<SysUser_Info>, ISysUserInfoService
    {
        public ISysOrganInfoRespository _sysOrganInfo;
        public SysUserInfoService(IUnitOfWork unitOfWork, IBaseRepository<SysUser_Info> currentRepository, ISysOrganInfoRespository sysOrganInfo) : base(unitOfWork, currentRepository)
        {
            this._sysOrganInfo = sysOrganInfo;
        }
        public async Task<bool> getUserInfo(string LoginCode, string Password, int SchoolYearID, int Semester)
        {   
            var userInfo = await currentRepository.FirstOrDefault(c => c.LoginCode.Equals(LoginCode) && c.Password.Equals(Password) && c.Status.Equals(0));
            var organInfo = await _sysOrganInfo.Select(c=>c.ID.Equals(userInfo.ID));
            return true;
        }
    }
}
