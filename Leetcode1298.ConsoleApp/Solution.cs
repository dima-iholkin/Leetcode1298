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
        HashSet<int> obtainedBoxes = new HashSet<int>();

        foreach (int item in initialBoxes)
        {
            if (obtainedKeys[item] == 1)
            {
                boxesToOpen.Enqueue(item);
            } else
            {
                obtainedBoxes.Add(item);
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
        HashSet<int> obtainedBoxes,
        int[] candiesInEachBox
    )
    {
        total += candiesInEachBox[boxNumber];

        foreach (int item in keysContainedInEachBox[boxNumber])
        {
            obtainedKeys[item] = 1;

            if (obtainedBoxes.Contains(item))
            {
                obtainedBoxes.Remove(item);
                boxesToOpen.Enqueue(item);
            }
        }

        foreach (int item in boxesContainedInEachBox[boxNumber])
        {
            if (obtainedKeys[item] == 1)
            {
                boxesToOpen.Enqueue(item);
            }
            else
            {
                obtainedBoxes.Add(item);
            }
        }
    }
}