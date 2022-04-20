namespace Leetcode1298.ConsoleApp;



public class Solution
{
    private Queue<int> boxesToOpen = new Queue<int>();
    private int total = 0;



    public int MaxCandies(
        int[] obtainedKeys,
        int[] candiesInEachBox,
        int[][] keysContainedInEachBox,
        int[][] boxesContainedInEachBox,
        int[] initialBoxes
    )
    {
        int arrayLength = obtainedKeys.Length;
        int[] obtainedBoxes = new int[arrayLength];

        foreach (int item in initialBoxes)
        {
            obtainedBoxes[item] = 1;

            if (obtainedKeys[item] == 1)
            {
                boxesToOpen.Enqueue(item);
            }
        }

        while (boxesToOpen.Any())
        {
            int item = boxesToOpen.Dequeue();
            OpenBox(
                item,
                keysContainedInEachBox,
                boxesContainedInEachBox,
                obtainedKeys,
                obtainedBoxes,
                candiesInEachBox
            );
        }

        return total;
    }



    private void OpenBox(
        int boxNumber,
        int[][] keysContainedInEachBox,
        int[][] boxesContainedInEachBox,
        int[] obtainedKeys,
        int[] obtainedBoxes,
        int[] candiesInEachBox
    )
    {
        foreach (int item in keysContainedInEachBox[boxNumber])
        {
            obtainedKeys[item] = 1;

            if (obtainedBoxes[item] == 1)
            {
                boxesToOpen.Enqueue(item);
            }
        }

        foreach (int item in boxesContainedInEachBox[boxNumber])
        {
            obtainedBoxes[item] = 1;

            if (obtainedKeys[item] == 1)
            {
                boxesToOpen.Enqueue(item);
            }
        }

        total += candiesInEachBox[boxNumber];
    }
}