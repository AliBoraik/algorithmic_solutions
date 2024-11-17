namespace LeetCode.Tasks;

public class PascalTriangle
{
    /*
     Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
       
       In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
     */
    public IList<int> GetRow(int rowIndex)
    {
        var triangle = new List<int> { 1 };
        if (rowIndex == 0) return triangle;
        triangle.Add(1);
        if (rowIndex == 1)
        {
            return triangle;
        }
        for (int i = 0; i < rowIndex -1; i++)
        {
            var newRow = new List<int>();
            for (int j = 1; j < triangle.Count; j++)
            {
                newRow.Add(triangle[j-1]+triangle[j]);
            }
            triangle[1] = newRow[0];
            for (int j = 1; j < newRow.Count; j++)
            {
                triangle[j+1] = (newRow[j]);
            }
            triangle.Add(1);
        }
        return triangle;
    }
}