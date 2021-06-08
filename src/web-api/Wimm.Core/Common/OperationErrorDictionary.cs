namespace Wimm.Core.Common
{
    public static class OperationErrorDictionary
    {
        public static class AccountTransaction
        {
            public static OperationError InsufficientFunds() =>
               new OperationError("Unfortunately your account has not enough funds.");

            //public static OperationError CarDoesNotExist() =>
            //   new OperationError("Unfortunately the car specified in the reservation does not exist in out catalog.");
        }
    }
}
