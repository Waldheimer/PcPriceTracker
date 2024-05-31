using PcPriceTracker.Domain.Entities;

namespace PcPriceTracker.Domain.Primitives
{
    public class DataResult
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public DataError Error { get; }
        protected internal DataResult(bool isSuccess, DataError error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        public static DataResult Success() => new(true, DataError.None);
        public static DataResult<TValue> Success<TValue>(TValue value) => new(value, true, DataError.None);
        public static DataResult Failure(DataError error) => new(false, error);

        public static DataResult<TValue> Failure<TValue>(DataError error) => new(default, false, error);

        public static DataResult<TValue> Create<TValue>(TValue? value) => value is not null ? Success(value) : Failure<TValue>(DataError.NullValue);

    }

    public class DataResult<TValue> : DataResult
    {
        private readonly TValue? _value;


        public DataResult(TValue? value, bool success, DataError error)
            : base(success, error) => _value = value;

        public TValue Value => _value!;
        //IsSuccess 
        //? _value! 
        //: throw new InvalidOperationException("Value of a failed Result is not available");

        public static implicit operator DataResult<TValue>(TValue? value) => Create(value);
    }
}
