using AppExampleCofCImpl.DataManagement.Interfaces;

namespace AppExampleCofCImpl.DataManagement.DataStoreAccess
{
    public sealed class DataAccess
    {
        private static readonly Lazy<DataAccess> _instance = new(() => new DataAccess());

        public static DataAccess Instance => _instance.Value;

        private IDataStore _store;   // Underlying data provider

        private DataAccess()
        {
            _store = new LocalDataStore();
            // later: _store = new AwsDataStore();
        }

        // Public method to replace provider (optional)
        public void SetProvider(IDataStore provider)
        {
            _store = provider;
        }

        // ----------------------- Delegated async calls -----------------------

        public async Task<bool> ValidateLoginAsync(int loginId)
        {
            bool result = await _store.ValidateLoginAsync(loginId);
            return result;
        }
        public async Task<bool> ValidatePasswordAsync(int loginId, string password)
        {
            bool result = await _store.ValidatePasswordAsync(loginId, password);
            return result;
        }

        public async Task<bool> ValidateAccountAsync(int number)
        {
            bool result = await _store.ValidateAccountAsync(number);
            return result;
        }
    }
}
