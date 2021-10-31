using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.Shared.Domain.ValueObject
{
    public class IdentityValueObject : ValueObject
    {
        public Guid Value { get; }

        public IdentityValueObject(Guid value)
        {
            Value = value;
        }

        public static Result<IdentityValueObject> Create(Guid value)
        {
            return Result.Success(new IdentityValueObject(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static implicit operator Guid(IdentityValueObject identityValueObject)
        {
            return identityValueObject.Value;
        }
    }
}
