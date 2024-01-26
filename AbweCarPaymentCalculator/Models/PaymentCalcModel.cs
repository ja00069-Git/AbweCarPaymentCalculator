using System.ComponentModel.DataAnnotations;

namespace AbweCarPaymentCalculator.Models;
/// <summary>
/// Jabesi Abwe
/// 26/01/2024
/// The model for the Payment Calculator, which calculates the monthly payment based on the purchase price, interest rate, and loan term.
/// </summary>
public class PaymentCalcModel
{
    /// <summary>
    /// Gets or sets the purchase price.
    /// </summary>
    /// <value>
    /// The purchase price.
    /// </value>
    [Required(ErrorMessage = "Please Enter a Purchase")]
    [Range(1, double.MaxValue, ErrorMessage = "Purchase Price must be greater than 0.")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Gets or sets the interest rate.
    /// </summary>
    /// <value>
    /// The interest rate.
    /// </value>
    [Required(ErrorMessage = "Please Enter a Interest Rate.")]
    [Range(0, 20, ErrorMessage = "Interest Rate must be between 0 and 20.")]
    public float? InterestRate { get; set; }

    /// <summary>
    /// Gets or sets the loan term.
    /// </summary>
    /// <value>
    /// The loan term.
    /// </value>
    [Required(ErrorMessage = "Please Enter a Loan Term.")]
    [Range(1, 72, ErrorMessage = "Loan Term must be between 1 and 7.")]
    public int? LoanTerm { get; set; }

    /// <summary>
    /// Calculates the monthly payment.
    /// </summary>
    /// <returns>Return the monthly payment</returns>
    public double? CalculateMonthlyPayment()
    {
        float? decimalInterestRate = InterestRate / 100;
        const int months = 12;
        double? monthlyPayment = PurchasePrice * (decimalInterestRate / months) /
                             (1 - Math.Pow((double)(1 + decimalInterestRate / months)!,
                                 (double)(-months * LoanTerm)!));

        return monthlyPayment;
    }
}