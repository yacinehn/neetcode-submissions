class Solution {
    calPoints(operations) {
        let result = [];
        for (let i = 0; i < operations.length; i++) {
            if (operations[i] === "C") {
                result.pop();
            } else if (operations[i] === "+") {
                let plusValue = result[result.length - 1] + result[result.length - 2];
                result.push(plusValue);
            } else if (operations[i] === "D") {
                let doubleValue = result[result.length - 1] * 2;
                result.push(doubleValue);
            } else {
                result.push(parseInt(operations[i]));
            }
        }
        return result.reduce((a, b) => a + b, 0);
    }
}
