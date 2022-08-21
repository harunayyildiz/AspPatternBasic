using EntityLayer.Conctete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.ValidationRules.FluentValidation
{
    class TodoItemValidation : AbstractValidator<TodoItem>
    {
        public TodoItemValidation()
        {
            //Kural Yazma-Merkezi Noktadan Hata Yönetimi
            RuleFor(p => p.Subject).NotEmpty().WithMessage("Görev başlığı ismi boş olamaz");
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Content).NotEmpty();

            //RuleFor(p => p.UnitPrice).GreaterThan(0); //0 dan Büyük olmalı
            //RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            //RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);
            //CategoryId = 2 ise UnitPrice 10 dan büyük olmalı


        }
    }
}
