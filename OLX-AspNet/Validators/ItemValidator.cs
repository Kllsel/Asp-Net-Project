using FluentValidation;
using OLX_AspNet.Data.Entities;

namespace OLX_AspNet.Validators
{
    public class ItemValidator : AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(4000);

            RuleFor(x => x.Title)
                .NotEmpty()
                .Length(10, 1000);

            RuleFor(x => x.Address)
                .NotEmpty()
                .MaximumLength(1000);

            RuleFor(x => x.Image)
                .Empty();

            RuleFor(x => x.CategoryId)
               .NotEmpty();

        }
    }
}
