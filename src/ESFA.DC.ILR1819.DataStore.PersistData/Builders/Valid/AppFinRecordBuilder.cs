﻿using ESFA.DC.ILR.Model.Interface;
using ESFA.DC.ILR1819.DataStore.EF.Valid;

namespace ESFA.DC.ILR1819.DataStore.PersistData.Builders.Valid
{
    public class AppFinRecordBuilder
    {
        public static AppFinRecord BuildValidAppFinRecord(IMessage ilr, ILearner learner, ILearningDelivery learningDelivery, IAppFinRecord appFinRecord)
        {
            return new AppFinRecord
            {
                LearnRefNumber = learner.LearnRefNumber,
                UKPRN = ilr.HeaderEntity.SourceEntity.UKPRN,
                AFinAmount = appFinRecord.AFinAmount,
                AFinCode = appFinRecord.AFinCode,
                AFinDate = appFinRecord.AFinDate,
                AFinType = appFinRecord.AFinType,
                AimSeqNumber = learningDelivery.AimSeqNumber
            };
        }
    }
}