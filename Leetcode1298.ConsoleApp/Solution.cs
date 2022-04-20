namespace Leetcode1298.ConsoleApp;



public class Solution
{
    private HashSet<int> boxesToCheck = new HashSet<int>();

    public int MaxCandies(
        int[] openedBoxes, 
        int[] candiesInEachBox, 
        int[][] keysContainedInEachBox, 
        int[][] boxesContainedInEachBox, 
        int[] initialBoxes
    )
    {
        int arrayLength = openedBoxes.Length;
        int[] obtainedBoxes = new int[arrayLength];
        int[] obtainedKeys = new int[arrayLength];

        foreach (int item in initialBoxes)
        {
            obtainedBoxes[item] = 1;
            
            if (openedBoxes[item] == 1)
            {
                boxesToCheck.Add(item);
            }
        }

        while (boxesToCheck.Any())
        {
            int item = boxesToCheck.First();
            boxesToCheck.Remove(item);
            CheckBox(
                item,
                keysContainedInEachBox,
                boxesContainedInEachBox,
                obtainedKeys,
                obtainedBoxes,
                openedBoxes
            );
        }

        return CountCandiesSum(
            openedBoxes,
            obtainedBoxes,
            candiesInEachBox
        );
    }



    private void CheckBox(
        int boxNumber,
        int[][] keysContainedInEachBox,
        int[][] boxesContainedInEachBox,
        int[] obtainedKeys,
        int[] obtainedBoxes,
        int[] openedBoxes
    )
    {
        foreach (int item in keysContainedInEachBox[boxNumber])
        {
            obtainedKeys[item] = 1;

            if (obtainedBoxes[item] == 1)
            {
                openedBoxes[item] = 1;
                boxesToCheck.Add(item);
            }
        }

        foreach (int item in boxesContainedInEachBox[boxNumber])
        {
            obtainedBoxes[item] = 1;

            if (obtainedKeys[item] == 1 || openedBoxes[item] == 1)
            {
                openedBoxes[item] = 1;
                boxesToCheck.Add(item);
            }
        }
    }



    private int CountCandiesSum(
        int[] openedBoxes, 
        int[] obtainedBoxes, 
        int[] candiesInEachBox
    )
    {
        int total = 0;

        foreach (var item in openedBoxes.Select((boxNumber, index) => (boxNumber, index)))
        {
            if (item.boxNumber == 1 && obtainedBoxes[item.index] == 1)
            {
                total += candiesInEachBox[item.index];
            }
        }

        return total;
    }
}