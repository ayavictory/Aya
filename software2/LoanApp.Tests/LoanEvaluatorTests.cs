// LoanApp.Tests/LoanEvaluatorTests.cs
using Xunit;
using LoanApp;

namespace LoanApp.Tests
{
    public class LoanEvaluatorTests
    {
        [Fact]
        public void GetLoanEligibility_Should_Return_NotEligible_When_Income_Low()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(1500, true, 800, 0, true);
            Assert.Equal("Not Eligible", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_Eligible_When_EmployedHighCreditZeroDependents()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(3000, true, 700, 0, false);
            Assert.Equal("Eligible", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_ReviewManually_When_EmployedHighCreditTwoDependents()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(3000, true, 700, 2, false);
            Assert.Equal("Review Manually", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_NotEligible_When_EmployedHighCreditThreeDependents()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(3000, true, 700, 3, false);
            Assert.Equal("Not Eligible", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_ReviewManually_When_EmployedMediumCreditOwnsHouse()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(3000, true, 600, 0, true);
            Assert.Equal("Review Manually", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_NotEligible_When_EmployedMediumCreditDoesNotOwnHouse()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(3000, true, 600, 0, false);
            Assert.Equal("Not Eligible", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_NotEligible_When_EmployedLowCredit()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(3000, true, 599, 0, false);
            Assert.Equal("Not Eligible", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_Eligible_When_UnemployedHighCreditHighIncomeOwnsHouse()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(6000, false, 750, 0, true);
            Assert.Equal("Eligible", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_ReviewManually_When_UnemployedMediumCreditZeroDependents()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(4000, false, 650, 0, false);
            Assert.Equal("Review Manually", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_NotEligible_When_UnemployedMediumCreditHasDependents()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(4000, false, 650, 1, false);
            Assert.Equal("Not Eligible", result);
        }

        [Fact]
        public void GetLoanEligibility_Should_Return_NotEligible_When_UnemployedLowCredit()
        {
            var evaluator = new LoanEvaluator();
            var result = evaluator.GetLoanEligibility(4000, false, 649, 0, false);
            Assert.Equal("Not Eligible", result);
        }
    }
}