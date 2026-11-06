using System.ComponentModel.DataAnnotations;

namespace BashCVPortfolio.Models
{
    public class TaxCalculatorViewModel
    {
        // Annual income
        [Required(ErrorMessage = "Please enter your annual gross income.")]
        [Range(0, 1000000000000,
            ErrorMessage = "Please enter a valid income amount.")]
        [Display(Name = "Annual Gross Income (₦)")]
        public decimal AnnualGrossIncome { get; set; }

        // Eligible deductions and reliefs
        [Range(0, 1000000000000)]
        [Display(Name = "Annual Rent Paid (₦)")]
        public decimal AnnualRentPaid { get; set; }

        [Range(0, 1000000000000)]
        [Display(Name = "Annual Pension Contribution (₦)")]
        public decimal PensionContribution { get; set; }

        [Range(0, 1000000000000)]
        [Display(Name = "Annual NHF Contribution (₦)")]
        public decimal NHFContribution { get; set; }

        [Range(0, 1000000000000)]
        [Display(Name = "Annual NHIS Contribution (₦)")]
        public decimal NHISContribution { get; set; }

        [Range(0, 1000000000000)]
        [Display(Name = "Qualifying Mortgage Interest (₦)")]
        public decimal MortgageInterest { get; set; }

        [Range(0, 1000000000000)]
        [Display(Name = "Qualifying Life Insurance Premium (₦)")]
        public decimal LifeInsurancePremium { get; set; }

        // Calculation results
        public decimal RentRelief { get; set; }

        public decimal TotalDeductions { get; set; }

        public decimal TaxableIncome { get; set; }

        public decimal AnnualTaxPayable { get; set; }

        public decimal MonthlyTaxPayable { get; set; }

        public decimal NetAnnualIncome { get; set; }

        public string TaxMessage { get; set; } = "";
    }
}
