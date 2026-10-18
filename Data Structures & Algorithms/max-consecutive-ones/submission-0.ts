class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    findMaxConsecutiveOnes(nums: number[]): number {
    let maximum = 0;
    let count = 0;
    for (const num of nums) {
        count = num === 1 ? count + 1 : 0;
        maximum = Math.max(maximum, count);
    }
    return maximum;
}
}
 
