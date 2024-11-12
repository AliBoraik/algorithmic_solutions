using LeetCode.Models;

namespace LeetCode.Tasks;

public class BinaryTreeTraversal
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> nums = [];
        PreorderTraversalHelper(root , nums);
        return nums;
    }
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> nums = [];
        PostorderTraversalHelper(root , nums);
        return nums;
    }
    private void PostorderTraversalHelper(TreeNode root , List<int> nums)
    {
        if (root == null)
        {
            return;
        }
        PostorderTraversalHelper(root.left , nums);
        PostorderTraversalHelper(root.right, nums);
        nums.Add(root.val);
    }
    private void PreorderTraversalHelper(TreeNode root , List<int> nums)
    {
        if (root == null)
        {
            return;
        }
        nums.Add(root.val);
        PreorderTraversalHelper(root.left , nums);
        PreorderTraversalHelper(root.right, nums);
    }
    
}