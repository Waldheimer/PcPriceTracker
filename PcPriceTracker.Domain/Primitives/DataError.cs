namespace PcPriceTracker.Domain.Primitives
{
    public class DataError : IEquatable<DataError>
    {
        public static readonly DataError None = new(DataErrorCode.None, string.Empty);
        public static readonly DataError NullValue = new(DataErrorCode.NullValue, "The specified result value is null");

        public DataErrorCode Code { get; }
        public string Message { get; }

        public DataError(DataErrorCode code, string message)
        {
            Code = code;
            Message = message;
        }
        public static implicit operator DataErrorCode(DataError error) => error.Code;

        public static bool operator ==(DataError? e1, DataError? e2)
        {
            if (e1 is null && e2 is null)
            {
                return true;
            }
            if (e1 is null || e2 is null)
            {
                return false;
            }
            return e1.Equals(e2);
        }
        public static bool operator !=(DataError? e1, DataError? e2) => !(e1 == e2);

        public bool Equals(DataError? other)
        {
            if (other is null)
            {
                return false;
            }

            return Code == other.Code && Message == other.Message;
        }
        public override bool Equals(object? obj) => obj is DataError error && Equals(error);

        public override int GetHashCode() => HashCode.Combine(Code, Message);

        public override string ToString() => Code.ToString();
    }
}
