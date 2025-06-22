// LoanApp/LoanEvaluator.cs
namespace LoanApp
{
    public class LoanEvaluator
    {
        public string GetLoanEligibility(int income, bool hasJob, int creditScore, int dependents, bool ownsHouse)
        {
            if (income < 2000)
                return "Not Eligible";

            if (hasJob)
            {
                return EvaluateEmployedApplicant(creditScore, dependents, ownsHouse);
            }
            else
            {
                return EvaluateUnemployedApplicant(income, creditScore, dependents, ownsHouse);
            }
        }

        private string EvaluateEmployedApplicant(int creditScore, int dependents, bool ownsHouse)
        {
            if (creditScore >= 700)
            {
                return EvaluateHighCreditEmployed(dependents);
            }
            else if (creditScore >= 600)
            {
                return EvaluateMediumCreditEmployed(ownsHouse);
            }
            else
            {
                return "Not Eligible";
            }
        }

        private string EvaluateHighCreditEmployed(int dependents)
        {
            if (dependents == 0)
                return "Eligible";
            else if (dependents <= 2)
                return "Review Manually";
            else
                return "Not Eligible";
        }

        private string EvaluateMediumCreditEmployed(bool ownsHouse)
        {
            if (ownsHouse)
                return "Review Manually";
            else
                return "Not Eligible";
        }

        private string EvaluateUnemployedApplicant(int income, int creditScore, int dependents, bool ownsHouse)
        {
            if (creditScore >= 750 && income > 5000 && ownsHouse)
                return "Eligible";
            else if (creditScore >= 650 && dependents == 0)
                return "Review Manually";
            else
                return "Not Eligible";
        }
    }
}