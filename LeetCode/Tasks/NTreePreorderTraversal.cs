using LeetCode.Models;

namespace LeetCode.Tasks;

public class NTreePreorderTraversal
{
    /*
     * Given the root of an n-ary tree,
     * return the preorder traversal of its nodes' values.
       
       Nary-Tree input serialization is represented in their level order traversal. 
       Each group of children is separated by the null value (See examples)
     */
    public IList<int> Preorder(Node root) {

        if(root == null){
            return new List<int>();
        }
        var stack = new Stack<Node>();
        var ans = new List<int>();
        stack.Push(root);

        while(stack.Count > 0){
            var currentNode = stack.Pop();
            ans.Add(currentNode.val);
            if (currentNode.children.Count == 0) continue;
            //we are adding the children in reverse order
            for(int i = currentNode.children.Count-1; i >= 0; i--){
                stack.Push(currentNode.children[i]);
            }

        }

        return ans;
    }
    
}