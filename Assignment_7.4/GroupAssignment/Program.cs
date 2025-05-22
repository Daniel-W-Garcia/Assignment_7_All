
int MinCostClimbingStairs(int[] inputArray)
{
    int arrayLength = inputArray.Length;
    
    if (arrayLength == 0) return 0;
    if (arrayLength == 1) return inputArray[0];
    
    int oneStepBefore = inputArray[0]; //
    int twoStepsBefore = 0;
    
    for (int i = 1; i < arrayLength; i++)
    {
        int costToClimbToCurrentStep;
        if (oneStepBefore < twoStepsBefore)
        {
            costToClimbToCurrentStep = oneStepBefore;
        }
        else
        {
            costToClimbToCurrentStep = twoStepsBefore;
        }
        
        int accumulatedCost = inputArray[i] + costToClimbToCurrentStep;
        
        twoStepsBefore = oneStepBefore;
        oneStepBefore = accumulatedCost;
    }

    if (oneStepBefore < twoStepsBefore)
    {
        return oneStepBefore;
    }
    else
    {
        return twoStepsBefore;
    }
}
// [1,100,1,1,2,100,1,1,100,1]
int[] test = {1, 100, 1, 1, 2, 100, 1, 1, 100, 1};
MinCostClimbingStairs(test);