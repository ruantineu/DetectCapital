# HackerRank Challenge - Detect Capital Use

This repository contains a solution for the **"Detect Capital Use"** problem, commonly found in coding interviews and competitive programming platforms like HackerRank.

## 📝 Problem Statement

We define the usage of capitals in a word to be correct when one of the following conditions is met:

1. All letters in the word are uppercase (e.g., `"USA"`).
2. All letters in the word are lowercase (e.g., `"leetcode"`).
3. Only the first letter is uppercase, and the rest are lowercase (e.g., `"Google"`).

Given a string `word`, return `true` if the usage of capitals is correct.

### **Example Inputs & Outputs**
| Input   | Output |
|---------|--------|
| `"USA"` | `true`  |
| `"leetcode"` | `true`  |
| `"Google"` | `true`  |
| `"FlaG"` | `false`  |

---

## 🚀 Solution in C#

The implementation follows an optimized approach using a single loop (`O(n)`) to check the conditions without creating unnecessary string copies.

### **Implementation**
```csharp
using System;

public class Solution {
    public bool DetectCapitalUse(string word) {
        int uppercaseCount = 0;
        int n = word.Length;

        // Count uppercase letters
        foreach (char c in word) {
            if (char.IsUpper(c)) {
                uppercaseCount++;
            }
        }

        // Valid cases: All uppercase, all lowercase, or first letter uppercase and rest lowercase
        return uppercaseCount == n || uppercaseCount == 0 || (uppercaseCount == 1 && char.IsUpper(word[0]));
    }

    // Test cases
    public static void Main() {
        Solution solution = new Solution();
        
        Console.WriteLine(solution.DetectCapitalUse("USA"));      // True
        Console.WriteLine(solution.DetectCapitalUse("leetcode")); // True
        Console.WriteLine(solution.DetectCapitalUse("Google"));   // True
        Console.WriteLine(solution.DetectCapitalUse("FlaG"));     // False
    }
}
