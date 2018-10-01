﻿using ESFA.DC.ILR.FundingService.FM35.FundingOutput.Model.Output;
using ESFA.DC.ILR1819.DataStore.EF;

namespace ESFA.DC.ILR1819.DataStore.PersistData.Builders
{
    public class FM35LearningDeliveryBuilder
    {
        public static FM35_LearningDelivery BuildLearningDelivery(int ukPrn, string learnerRefNum, LearningDelivery attribute)
        {
            return new FM35_LearningDelivery
            {
                UKPRN = ukPrn,
                LearnRefNumber = learnerRefNum,
                AimSeqNumber = attribute.AimSeqNumber ?? 0,
                AchApplicDate = attribute.LearningDeliveryValue.AchApplicDate,
                Achieved = attribute.LearningDeliveryValue.Achieved,
                AchieveElement = attribute.LearningDeliveryValue.AchieveElement,
                AchievePayElig = attribute.LearningDeliveryValue.AchievePayElig,
                AchievePayPctPreTrans = attribute.LearningDeliveryValue.AchievePayPctPreTrans,
                AchPayTransHeldBack = attribute.LearningDeliveryValue.AchPayTransHeldBack,
                ActualDaysIL = attribute.LearningDeliveryValue.ActualDaysIL,
                ActualNumInstalm = attribute.LearningDeliveryValue.ActualNumInstalm,
                ActualNumInstalmPreTrans = attribute.LearningDeliveryValue.ActualNumInstalmPreTrans,
                ActualNumInstalmTrans = attribute.LearningDeliveryValue.ActualNumInstalmTrans,
                AdjLearnStartDate = attribute.LearningDeliveryValue.AdjLearnStartDate,
                AdltLearnResp = attribute.LearningDeliveryValue.AdltLearnResp,
                AgeAimStart = attribute.LearningDeliveryValue.AgeAimStart,
                AimValue = attribute.LearningDeliveryValue.AimValue,
                AppAdjLearnStartDate = attribute.LearningDeliveryValue.AppAdjLearnStartDate,
                AppAgeFact = attribute.LearningDeliveryValue.AppAgeFact,
                AppATAGTA = attribute.LearningDeliveryValue.AppATAGTA,
                AppCompetency = attribute.LearningDeliveryValue.AppCompetency,
                AppFuncSkill = attribute.LearningDeliveryValue.AppFuncSkill,
                AppFuncSkill1618AdjFact = attribute.LearningDeliveryValue.AppFuncSkill1618AdjFact,
                AppKnowl = attribute.LearningDeliveryValue.AppKnowl,
                AppLearnStartDate = attribute.LearningDeliveryValue.AppLearnStartDate,
                ApplicEmpFactDate = attribute.LearningDeliveryValue.ApplicEmpFactDate,
                ApplicFactDate = attribute.LearningDeliveryValue.ApplicFactDate,
                ApplicFundRateDate = attribute.LearningDeliveryValue.ApplicFundRateDate,
                ApplicProgWeightFact = attribute.LearningDeliveryValue.ApplicProgWeightFact,
                ApplicUnweightFundRate = attribute.LearningDeliveryValue.ApplicUnweightFundRate,
                ApplicWeightFundRate = attribute.LearningDeliveryValue.ApplicWeightFundRate,
                AppNonFund = attribute.LearningDeliveryValue.AppNonFund,
                AreaCostFactAdj = attribute.LearningDeliveryValue.AreaCostFactAdj,
                BalInstalmPreTrans = attribute.LearningDeliveryValue.BalInstalmPreTrans,
                BaseValueUnweight = attribute.LearningDeliveryValue.BaseValueUnweight,
                CapFactor = attribute.LearningDeliveryValue.CapFactor,
                DisUpFactAdj = attribute.LearningDeliveryValue.DisUpFactAdj,
                EmpOutcomePayElig = attribute.LearningDeliveryValue.EmpOutcomePayElig,
                EmpOutcomePctHeldBackTrans = attribute.LearningDeliveryValue.EmpOutcomePctHeldBackTrans,
                EmpOutcomePctPreTrans = attribute.LearningDeliveryValue.EmpOutcomePctPreTrans,
                EmpRespOth = attribute.LearningDeliveryValue.EmpRespOth,
                ESOL = attribute.LearningDeliveryValue.ESOL,
                FullyFund = attribute.LearningDeliveryValue.FullyFund,
                FundLine = attribute.LearningDeliveryValue.FundLine,
                FundStart = attribute.LearningDeliveryValue.FundStart,
                LargeEmployerID = attribute.LearningDeliveryValue.LargeEmployerID,
                LargeEmployerFM35Fctr = attribute.LearningDeliveryValue.LargeEmployerFM35Fctr,
                LargeEmployerStatusDate = attribute.LearningDeliveryValue.LargeEmployerStatusDate,
                LTRCUpliftFctr = attribute.LearningDeliveryValue.LTRCUpliftFctr,
                NonGovCont = attribute.LearningDeliveryValue.NonGovCont,
                OLASSCustody = attribute.LearningDeliveryValue.OLASSCustody,
                OnProgPayPctPreTrans = attribute.LearningDeliveryValue.OnProgPayPctPreTrans,
                OutstndNumOnProgInstalm = attribute.LearningDeliveryValue.OutstndNumOnProgInstalm,
                OutstndNumOnProgInstalmTrans = attribute.LearningDeliveryValue.OutstndNumOnProgInstalmTrans,
                PlannedNumOnProgInstalm = attribute.LearningDeliveryValue.PlannedNumOnProgInstalm,
                PlannedNumOnProgInstalmTrans = attribute.LearningDeliveryValue.PlannedNumOnProgInstalmTrans,
                PlannedTotalDaysIL = attribute.LearningDeliveryValue.PlannedTotalDaysIL,
                PlannedTotalDaysILPreTrans = attribute.LearningDeliveryValue.PlannedTotalDaysILPreTrans,
                PropFundRemain = attribute.LearningDeliveryValue.PropFundRemain,
                PropFundRemainAch = attribute.LearningDeliveryValue.PropFundRemainAch,
                PrscHEAim = attribute.LearningDeliveryValue.PrscHEAim,
                Residential = attribute.LearningDeliveryValue.Residential,
                Restart = attribute.LearningDeliveryValue.Restart,
                SpecResUplift = attribute.LearningDeliveryValue.SpecResUplift,
                StartPropTrans = attribute.LearningDeliveryValue.StartPropTrans,
                ThresholdDays = attribute.LearningDeliveryValue.ThresholdDays,
                Traineeship = attribute.LearningDeliveryValue.Traineeship,
                Trans = attribute.LearningDeliveryValue.Trans,
                TrnAdjLearnStartDate = attribute.LearningDeliveryValue.TrnAdjLearnStartDate,
                TrnWorkPlaceAim = attribute.LearningDeliveryValue.TrnWorkPlaceAim,
                TrnWorkPrepAim = attribute.LearningDeliveryValue.TrnWorkPrepAim,
                UnWeightedRateFromESOL = attribute.LearningDeliveryValue.UnWeightedRateFromESOL,
                UnweightedRateFromLARS = attribute.LearningDeliveryValue.UnweightedRateFromLARS,
                WeightedRateFromESOL = attribute.LearningDeliveryValue.WeightedRateFromESOL,
                WeightedRateFromLARS = attribute.LearningDeliveryValue.WeightedRateFromLARS
            };
        }
    }
}
