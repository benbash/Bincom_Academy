
using BashCVPortfolio.Models;

namespace BashCVPortfolio.Services
{
    public class NigeriaTaxService
    {
        public void CalculateTax(TaxCalculatorViewModel model)
        {
            // 1. Calculate rent relief:
            // 20% of annual rent, subject to a maximum of ₦500,000.
            model.RentRelief = Math.Min(
                model.AnnualRentPaid * 0.20m,
                500000m
            );

            // 2. Calculate total eligible deductions.
            model.TotalDeductions =
                model.RentRelief +
                model.PensionContribution +
                model.NHFContribution +
                model.NHISContribution +
                model.MortgageInterest +
                model.LifeInsurancePremium;

            // 3. Calculate taxable income.
            model.TaxableIncome = Math.Max(
                0,
                model.AnnualGrossIncome - model.TotalDeductions
            );

            // 4. Apply the minimum-wage exemption.
            // This annualises ₦70,000 per month for a full year.
            // This applies to the employment-income estimate.
            if (model.AnnualGrossIncome <= 840000m)
            {
                model.AnnualTaxPayable = 0;
                model.MonthlyTaxPayable = 0;

                model.NetAnnualIncome = Math.Max(
                    0,
                    model.AnnualGrossIncome - model.TotalDeductions
                );

                model.TaxMessage =
                    "No tax is estimated because the annual employment income " +
                    "does not exceed the annualised national minimum wage threshold.";

                return;
            }

            // 5. Apply the graduated tax rates.
            decimal remainingIncome = model.TaxableIncome;
            decimal tax = 0;

            // First ₦800,000 at 0%
            decimal band = Math.Min(remainingIncome, 800000m);
            tax += band * 0.00m;
            remainingIncome -= band;

            // Next ₦2,200,000 at 15%
            band = Math.Min(remainingIncome, 2200000m);
            tax += band * 0.15m;
            remainingIncome -= band;

            // Next ₦9,000,000 at 18%
            band = Math.Min(remainingIncome, 9000000m);
            tax += band * 0.18m;
            remainingIncome -= band;

            // Next ₦13,000,000 at 21%
            band = Math.Min(remainingIncome, 13000000m);
            tax += band * 0.21m;
            remainingIncome -= band;

            // Next ₦25,000,000 at 23%
            band = Math.Min(remainingIncome, 25000000m);
            tax += band * 0.23m;
            remainingIncome -= band;

            // Any amount above ₦50,000,000 at 25%
            if (remainingIncome > 0)
            {
                tax += remainingIncome * 0.25m;
            }

            // 6. Store the calculation results.
            model.AnnualTaxPayable = Math.Round(tax, 2);

            model.MonthlyTaxPayable = Math.Round(
                model.AnnualTaxPayable / 12,
                2
            );

            model.NetAnnualIncome = Math.Max(
                0,
                model.AnnualGrossIncome -
                model.TotalDeductions -
                model.AnnualTaxPayable
            );

            model.TaxMessage =
                "Your estimated Nigerian personal income tax has been calculated.";
        }
    }
}
