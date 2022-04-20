using Leetcode1298.ConsoleApp;



Solution sol = new Solution();

int[] status = new int[] { 1, 0, 1, 0 };
int[] candies = new int[] { 7, 5, 4, 100 };

int[][] keys = new int[4][];
keys[0] = new int[]{ };
keys[1] = new int[]{ };
keys[2] = new int[]{ 1 };
keys[3] = new int[]{ };

int[][] containedBoxes = new int[4][];
containedBoxes[0] = new int[] { 1, 2 };
containedBoxes[1] = new int[] { 3 };
containedBoxes[2] = new int[] { };
containedBoxes[3] = new int[] { };

int[] initialBoxes = new int[] { 0 };

int total = sol.MaxCandies(
    status,
    candies,
    keys,
    containedBoxes,
    initialBoxes
);

Console.WriteLine("Max candies: " + total);
Console.ReadLine();