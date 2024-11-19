using System.Collections;
using System.Text;

namespace LeetCode.Tasks.LeetCode_75;

public class EqualRowAndColumnPairs
{
    /*
     Given a 0-indexed n x n integer matrix grid, return the number of pairs (ri, cj) such that row ri and column cj are equal.
       
       A row and column pair is considered equal if they contain the same elements in the same order (i.e., an equal array).
       
       11 1 
       1  11
     */
    public int EqualPairs(int[][] grid) 
    {
        var n = grid.Length;
        if(n == 1)
        {
            return 1;
        }

        var columnHash = new Dictionary<long, int>();
        var rowHash = new Dictionary<long, int>();
        
        for(int i = 0; i < n; ++i)
        {
            var hash = GetHash(grid[i]);
            columnHash.TryAdd(hash, 0);
            columnHash[hash] += 1;    
        }

        for(int i = 0; i < n; ++i)
        {
            var data = new int[n];
            for(int j = 0; j < n; ++j)
            {
                data[j] = grid[j][i];
            }

            var hash = GetHash(data);
            rowHash.TryAdd(hash, 0);
            rowHash[hash] += 1;    
        }

        var result = 0;
        foreach(var (key,value) in columnHash)
        {
            if(rowHash.TryGetValue(key, out var value1))
            {
                result += value1 * value;
            }
        }

        return result;    
    }

    public long GetHash(int[] data)
    {
        long result = 0;

        var power = 179;
        var modulo = 179424673;

        foreach(var num in data)
        {
            result = (result + (long) power * num)%modulo;
            power = (power * 179) % modulo; 
        }

        return result;
    }
    
}