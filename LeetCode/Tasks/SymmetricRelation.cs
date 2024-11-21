namespace LeetCode.Tasks;

public class SymmetricRelation
{
    public void Run()
    {
        var r = new HashSet<(char, char)> {
            ('a', 'a'), ('a', 'b'), ('a', 'c'),
            ('b', 'c'), ('c', 'a') };

        // Проверяем симметричность
        if (IsSymmetric(r))
        {
            Console.WriteLine("Отношение уже симметрично.");
        }
        else
        {
            Console.WriteLine("Отношение не симметрично. Необходимы следующие добавления:");
            var toAdd = new List<(char, char)>();


            foreach (var (x, y) in r)
            {
                // Если обратная пара отсутствует, добавляемв список
                if (!r.Contains((y, x)))
                {
                    toAdd.Add((y, x));
                }
            }

            foreach (var pair in toAdd)
            {
                Console.WriteLine($"Добавить пару: ({pair.Item1}, {pair.Item2})");
                r.Add(pair);
            }

            Console.WriteLine("Симметричное отношение R:");
            foreach (var pair in r)
            {
                Console.WriteLine($"({pair.Item1}, {pair.Item2})");
            }
        }
    } 
    private bool IsSymmetric(HashSet<(char, char)> relation)
    {
        foreach (var (x, y) in relation)
        {
            // Если (y, x) отсутствует в отношении, то оно не симметричное
            if (!relation.Contains((y, x)))
            {
                return false;
            }
        }
        return true;
    }
}

