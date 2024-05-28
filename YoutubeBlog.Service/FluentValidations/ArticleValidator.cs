using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.FluentValidations
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Başlık");

            RuleFor(x => x.Content)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("İçerik");
        }
    }
}
