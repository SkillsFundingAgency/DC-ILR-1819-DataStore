﻿CREATE TABLE [Rulebase].[AEC_ApprenticeshipPriceEpisode] (
    [UKPRN]                                                  INT             NOT NULL,
    [LearnRefNumber]                                         VARCHAR (12)    NOT NULL,
    [PriceEpisodeIdentifier]                                 VARCHAR (25)    NOT NULL,
    [TNP4]                                                   DECIMAL (12, 5) NULL,
    [TNP1]                                                   DECIMAL (12, 5) NULL,
    [EpisodeStartDate]                                       DATE            NULL,
    [TNP2]                                                   DECIMAL (12, 5) NULL,
    [TNP3]                                                   DECIMAL (12, 5) NULL,
    [PriceEpisodeUpperBandLimit]                             DECIMAL (12, 5) NULL,
    [PriceEpisodePlannedEndDate]                             DATE            NULL,
    [PriceEpisodeActualEndDate]                              DATE            NULL,
    [PriceEpisodeTotalTNPPrice]                              DECIMAL (12, 5) NULL,
    [PriceEpisodeUpperLimitAdjustment]                       DECIMAL (12, 5) NULL,
    [PriceEpisodePlannedInstalments]                         INT             NULL,
    [PriceEpisodeActualInstalments]                          INT             NULL,
    [PriceEpisodeInstalmentsThisPeriod]                      INT             NULL,
    [PriceEpisodeCompletionElement]                          DECIMAL (12, 5) NULL,
    [PriceEpisodePreviousEarnings]                           DECIMAL (12, 5) NULL,
    [PriceEpisodeInstalmentValue]                            DECIMAL (12, 5) NULL,
    [PriceEpisodeOnProgPayment]                              DECIMAL (12, 5) NULL,
    [PriceEpisodeTotalEarnings]                              DECIMAL (12, 5) NULL,
    [PriceEpisodeBalanceValue]                               DECIMAL (12, 5) NULL,
    [PriceEpisodeBalancePayment]                             DECIMAL (12, 5) NULL,
    [PriceEpisodeCompleted]                                  BIT             NULL,
    [PriceEpisodeCompletionPayment]                          DECIMAL (12, 5) NULL,
    [PriceEpisodeRemainingTNPAmount]                         DECIMAL (12, 5) NULL,
    [PriceEpisodeRemainingAmountWithinUpperLimit]            DECIMAL (12, 5) NULL,
    [PriceEpisodeCappedRemainingTNPAmount]                   DECIMAL (12, 5) NULL,
    [PriceEpisodeExpectedTotalMonthlyValue]                  DECIMAL (12, 5) NULL,
    [PriceEpisodeAimSeqNumber]                               BIGINT          NULL,
    [PriceEpisodeFirstDisadvantagePayment]                   DECIMAL (12, 5) NULL,
    [PriceEpisodeSecondDisadvantagePayment]                  DECIMAL (12, 5) NULL,
    [PriceEpisodeApplic1618FrameworkUpliftBalancing]         DECIMAL (12, 5) NULL,
    [PriceEpisodeApplic1618FrameworkUpliftCompletionPayment] DECIMAL (12, 5) NULL,
    [PriceEpisodeApplic1618FrameworkUpliftOnProgPayment]     DECIMAL (12, 5) NULL,
    [PriceEpisodeSecondProv1618Pay]                          DECIMAL (12, 5) NULL,
    [PriceEpisodeFirstEmp1618Pay]                            DECIMAL (12, 5) NULL,
    [PriceEpisodeSecondEmp1618Pay]                           DECIMAL (12, 5) NULL,
    [PriceEpisodeFirstProv1618Pay]                           DECIMAL (12, 5) NULL,
    [PriceEpisodeLSFCash]                                    DECIMAL (12, 5) NULL,
    [PriceEpisodeFundLineType]                               VARCHAR (100)   NULL,
    [PriceEpisodeSFAContribPct]                              DECIMAL (12, 5) NULL,
    [PriceEpisodeLevyNonPayInd]                              INT             NULL,
    [EpisodeEffectiveTNPStartDate]                           DATE            NULL,
    [PriceEpisodeFirstAdditionalPaymentThresholdDate]        DATE            NULL,
    [PriceEpisodeSecondAdditionalPaymentThresholdDate]       DATE            NULL,
    [PriceEpisodeContractType]                               VARCHAR (50)    NULL,
    [PriceEpisodePreviousEarningsSameProvider]               DECIMAL (12, 5) NULL,
    [PriceEpisodeTotProgFunding]                             DECIMAL (12, 5) NULL,
    [PriceEpisodeProgFundIndMinCoInvest]                     DECIMAL (12, 5) NULL,
    [PriceEpisodeProgFundIndMaxEmpCont]                      DECIMAL (12, 5) NULL,
    [PriceEpisodeTotalPMRs]                                  DECIMAL (12, 5) NULL,
    [PriceEpisodeCumulativePMRs]                             DECIMAL (12, 5) NULL,
    [PriceEpisodeCompExemCode]                               INT             NULL,
    [PriceEpisodeLearnerAdditionalPaymentThresholdDate]      DATE            NULL,
    [PriceEpisodeAgreeId]                                    VARCHAR (6)     NULL,
    [PriceEpisodeRedStartDate]                               DATE            NULL,
    [PriceEpisodeRedStatusCode]                              INT             NULL,
    PRIMARY KEY CLUSTERED ([UKPRN] ASC, [LearnRefNumber] ASC, [PriceEpisodeIdentifier] ASC)
);
GO

ALTER TABLE [Rulebase].[AEC_ApprenticeshipPriceEpisode] ADD CONSTRAINT [FK_AECApprenticeshipPriceEpisode_AECLearner] FOREIGN KEY([UKPRN], [LearnRefNumber])
REFERENCES [Rulebase].[AEC_Learner] ([UKPRN], [LearnRefNumber]);
GO

ALTER TABLE [Rulebase].[AEC_ApprenticeshipPriceEpisode] CHECK CONSTRAINT [FK_AECApprenticeshipPriceEpisode_AECLearner]