class Solution {
    /**
     * @param {number[]} arr
     * @return {number[]}
     */
    replaceElements(arr) {
        const length  = arr.length ; 
        const newArray = new Array(length);
        let rightMax = - 1 ; 
         for (let i = length -1  ; i >= 0  ; i -- ) { 
             newArray[i] =  rightMax ; 
             rightMax = Math.max(rightMax, arr[i])
        }
         return newArray ; 
    }
}
