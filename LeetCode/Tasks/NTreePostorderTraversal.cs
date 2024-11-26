using LeetCode.Models;

namespace LeetCode.Tasks;

public class NTreePostorderTraversal
{
    /*
     * Given the root of an n-ary tree, return the postorder traversal of its nodes' values.
       
       Nary-Tree input serialization is represented in their level order traversal. 
       Each group of children is separated by the null value (See examples)
     */
    readonly List<int> _res = new();
    
    void postOrder(Node root){
        if(root == null)
            return;
        foreach(Node child in root.children){
            postOrder(child);
            _res.Add(child.val);
        }
    }
    
    public IList<int> Postorder(Node root) {
        if(root == null)
            return new List<int>();
        postOrder(root);
        _res.Add(root.val);
        return _res;
    }
}