using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.Shared.Domain.ValueObject
{
    public class StringValueObject : ValueObject
    {
        public string Value { get; }

        public StringValueObject(string value)
        {
            Value = value;
        }

        public static Result<StringValueObject> Create(string value)
        {
            return Result.Success(new StringValueObject(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static implicit operator string(StringValueObject stringValueObject)
        {
            return stringValueObject.Value;
        }
    }
}
