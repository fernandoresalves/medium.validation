using System;
using FluentValidation;

namespace Medium.Validation
{
    public class CustomerPost
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public bool Draft { get; set; }
    }

    public class CustomerPostValidator : AbstractValidator<CustomerPost>
    {
        public CustomerPostValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty();

            When(customer => !customer.Draft, () => {
                RuleFor(customer => customer.Birthday).NotEmpty();
                RuleFor(customer => customer.Email).NotEmpty();
                RuleFor(customer => customer.PhoneNumber).NotEmpty();
                RuleFor(customer => customer.Gender).NotEmpty();
            });
        }            
    }
}
