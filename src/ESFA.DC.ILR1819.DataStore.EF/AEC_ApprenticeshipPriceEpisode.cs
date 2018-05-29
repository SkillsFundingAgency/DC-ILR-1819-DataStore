//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESFA.DC.ILR1819.DataStore.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class AEC_ApprenticeshipPriceEpisode
    {
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public string PriceEpisodeIdentifier { get; set; }
        public Nullable<decimal> TNP4 { get; set; }
        public Nullable<decimal> TNP1 { get; set; }
        public Nullable<System.DateTime> EpisodeStartDate { get; set; }
        public Nullable<decimal> TNP2 { get; set; }
        public Nullable<decimal> TNP3 { get; set; }
        public Nullable<decimal> PriceEpisodeUpperBandLimit { get; set; }
        public Nullable<System.DateTime> PriceEpisodePlannedEndDate { get; set; }
        public Nullable<System.DateTime> PriceEpisodeActualEndDate { get; set; }
        public Nullable<decimal> PriceEpisodeTotalTNPPrice { get; set; }
        public Nullable<decimal> PriceEpisodeUpperLimitAdjustment { get; set; }
        public Nullable<int> PriceEpisodePlannedInstalments { get; set; }
        public Nullable<int> PriceEpisodeActualInstalments { get; set; }
        public Nullable<int> PriceEpisodeInstalmentsThisPeriod { get; set; }
        public Nullable<decimal> PriceEpisodeCompletionElement { get; set; }
        public Nullable<decimal> PriceEpisodePreviousEarnings { get; set; }
        public Nullable<decimal> PriceEpisodeInstalmentValue { get; set; }
        public Nullable<decimal> PriceEpisodeOnProgPayment { get; set; }
        public Nullable<decimal> PriceEpisodeTotalEarnings { get; set; }
        public Nullable<decimal> PriceEpisodeBalanceValue { get; set; }
        public Nullable<decimal> PriceEpisodeBalancePayment { get; set; }
        public Nullable<bool> PriceEpisodeCompleted { get; set; }
        public Nullable<decimal> PriceEpisodeCompletionPayment { get; set; }
        public Nullable<decimal> PriceEpisodeRemainingTNPAmount { get; set; }
        public Nullable<decimal> PriceEpisodeRemainingAmountWithinUpperLimit { get; set; }
        public Nullable<decimal> PriceEpisodeCappedRemainingTNPAmount { get; set; }
        public Nullable<decimal> PriceEpisodeExpectedTotalMonthlyValue { get; set; }
        public Nullable<long> PriceEpisodeAimSeqNumber { get; set; }
        public Nullable<decimal> PriceEpisodeFirstDisadvantagePayment { get; set; }
        public Nullable<decimal> PriceEpisodeSecondDisadvantagePayment { get; set; }
        public Nullable<decimal> PriceEpisodeApplic1618FrameworkUpliftBalancing { get; set; }
        public Nullable<decimal> PriceEpisodeApplic1618FrameworkUpliftCompletionPayment { get; set; }
        public Nullable<decimal> PriceEpisodeApplic1618FrameworkUpliftOnProgPayment { get; set; }
        public Nullable<decimal> PriceEpisodeSecondProv1618Pay { get; set; }
        public Nullable<decimal> PriceEpisodeFirstEmp1618Pay { get; set; }
        public Nullable<decimal> PriceEpisodeSecondEmp1618Pay { get; set; }
        public Nullable<decimal> PriceEpisodeFirstProv1618Pay { get; set; }
        public Nullable<decimal> PriceEpisodeLSFCash { get; set; }
        public string PriceEpisodeFundLineType { get; set; }
        public Nullable<decimal> PriceEpisodeSFAContribPct { get; set; }
        public Nullable<int> PriceEpisodeLevyNonPayInd { get; set; }
        public Nullable<System.DateTime> EpisodeEffectiveTNPStartDate { get; set; }
        public Nullable<System.DateTime> PriceEpisodeFirstAdditionalPaymentThresholdDate { get; set; }
        public Nullable<System.DateTime> PriceEpisodeSecondAdditionalPaymentThresholdDate { get; set; }
        public string PriceEpisodeContractType { get; set; }
        public Nullable<decimal> PriceEpisodePreviousEarningsSameProvider { get; set; }
        public Nullable<decimal> PriceEpisodeTotProgFunding { get; set; }
        public Nullable<decimal> PriceEpisodeProgFundIndMinCoInvest { get; set; }
        public Nullable<decimal> PriceEpisodeProgFundIndMaxEmpCont { get; set; }
        public Nullable<decimal> PriceEpisodeTotalPMRs { get; set; }
        public Nullable<decimal> PriceEpisodeCumulativePMRs { get; set; }
        public Nullable<int> PriceEpisodeCompExemCode { get; set; }
    }
}
