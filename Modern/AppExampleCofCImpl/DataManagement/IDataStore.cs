namespace AppExampleCofCImpl.DataManagement
{
    public interface IDataStore
    {
        Task<bool> ValidateLoginAsync(int loginId);
        Task<bool> ValidatePasswordAsync(int loginId, string password);
        Task<bool> ValidateAccountAsync(int accountNumber);
    }
}
