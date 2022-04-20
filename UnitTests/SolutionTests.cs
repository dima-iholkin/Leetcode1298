using Xunit;
using Leetcode1298.ConsoleApp;



namespace UnitTests;



public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        Solution sol = new Solution();

        int[] status = new int[] { 1, 0, 1, 0 };
        int[] candies = new int[] { 7, 5, 4, 100 };

        int[][] keys = new int[4][];
        keys[0] = new int[] { };
        keys[1] = new int[] { };
        keys[2] = new int[] { 1 };
        keys[3] = new int[] { };

        int[][] containedBoxes = new int[4][];
        containedBoxes[0] = new int[] { 1, 2 };
        containedBoxes[1] = new int[] { 3 };
        containedBoxes[2] = new int[] { };
        containedBoxes[3] = new int[] { };

        int[] initialBoxes = new int[] { 0 };

        // Act
        int total = sol.MaxCandies(
            status,
            candies,
            keys,
            containedBoxes,
            initialBoxes
        );

        // Assert
        Assert.Equal(16, total);
    }



    [Fact]
    public void Test2()
    {
        // Arrange
        Solution sol = new Solution();

        int[] status = new int[] { 1, 0, 0, 0, 0, 0 };
        int[] candies = new int[] { 1, 1, 1, 1, 1, 1 };

        int[][] keys = new int[6][];
        keys[0] = new int[] { 1, 2, 3, 4, 5 };
        keys[1] = new int[] { };
        keys[2] = new int[] { };
        keys[3] = new int[] { };
        keys[4] = new int[] { };
        keys[5] = new int[] { };

        int[][] containedBoxes = new int[6][];
        containedBoxes[0] = new int[] { 1, 2, 3, 4, 5 };
        containedBoxes[1] = new int[] { };
        containedBoxes[2] = new int[] { };
        containedBoxes[3] = new int[] { };
        containedBoxes[4] = new int[] { };
        containedBoxes[5] = new int[] { };

        int[] initialBoxes = new int[] { 0 };

        // Act
        int total = sol.MaxCandies(
            status,
            candies,
            keys,
            containedBoxes,
            initialBoxes
        );

        // Assert
        Assert.Equal(6, total);
    }



    [Fact]
    public void Test3()
    {
        // Arrange
        Solution sol = new Solution();

        int[] status = new int[] { 1, 1,1 };
        int[] candies = new int[] { 100, 1, 100};

        int[][] keys = new int[3][];
        keys[0] = new int[] { };
        keys[1] = new int[] { 0, 2 };
        keys[2] = new int[] { };

        int[][] containedBoxes = new int[3][];
        containedBoxes[0] = new int[] { };
        containedBoxes[1] = new int[] { };
        containedBoxes[2] = new int[] { };

        int[] initialBoxes = new int[] { 1 };

        // Act
        int total = sol.MaxCandies(
            status,
            candies,
            keys,
            containedBoxes,
            initialBoxes
        );

        // Assert
        Assert.Equal(1, total);
    }
}