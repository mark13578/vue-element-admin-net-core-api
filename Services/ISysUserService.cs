using YourNamespace.Models;
using JMWebAPI.Models.DTO;
using JMWebAPI.Models.Query;
using JMWebAPI.Models.VO;

namespace YourNamespace.Services
{
    public interface ISysUserService
    {
        Task<PaginatedList<UserPageDTO>> ListPagedUsersAsync(UserPageQuery queryParams);

        Task<UserFormDTO> GetUserFormDataAsync(long userId);

        Task<bool> SaveUserAsync(UserFormDTO userForm);

        Task<bool> UpdateUserAsync(long userId, UserFormDTO userForm);

        Task<bool> DeleteUsersAsync(string idsStr);

        Task<bool> UpdatePasswordAsync(long userId, string password);

        Task<UserAuthInfoDTO> GetUserAuthInfoAsync(string username);

        Task<List<UserExportDTO>> ListExportUsersAsync(UserPageQuery queryParams);

        Task<UserInfoDTO> GetCurrentUserInfoAsync();

        Task<UserInfoDTO> GetCurrentUserInfo2Async();
    }
}
