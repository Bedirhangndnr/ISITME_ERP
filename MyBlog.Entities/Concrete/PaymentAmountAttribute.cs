using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using MyBlog.Shared.Entities.Abstract;

public class PaymentAmountAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var paymentAmount = value.ToString();

            // Virgülle ayrılmış sayıyı geçerli bir formata dönüştür
            paymentAmount = paymentAmount.Replace(",", "");
            if (!decimal.TryParse(paymentAmount, out decimal result))
            {
                return new ValidationResult("Ödenen Tutar geçerli bir sayı formatında değil.");
            }

            // 2 ondalık basamağa yuvarla
            result = Math.Round(result, 2);
        }


        return ValidationResult.Success;
    }
}
