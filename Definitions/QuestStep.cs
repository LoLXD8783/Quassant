﻿namespace QuasarFramework.Definitions
{
    internal class QuestStep
    {
        public bool isStepActive;

        public bool isStepCompleted = false;

        public List<StepCondition> stepConditions;

        public QuestStep(List<StepCondition> stepConditions)
        {
            this.stepConditions = stepConditions;
        }

        public void UpdateStepConditions() 
        {
            if (!isStepActive)
                return;

            foreach (StepCondition condition in stepConditions)
                if (!condition.isConditionCompleted)
                    condition.UpdateCondition();
        }
    }
}