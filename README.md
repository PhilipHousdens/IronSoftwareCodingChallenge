# Iron Software Coding Challenge – Old Phone Pad

## Overview

This project is a solution to the **Iron Software C# Coding Challenge**.

The objective is to convert a string of numeric input—representing key presses on an old mobile phone keypad—into readable text. Each numeric key maps to multiple characters, and pressing the same key multiple times cycles through those characters.

The input will always end with `#`, which represents the send button.

---

## Problem Description

Old mobile phones allowed users to type letters by pressing number keys multiple times.

Examples:
- Pressing `2` once returns `A`
- Pressing `2` twice returns `B`
- Pressing `2` three times returns `C`

To type two characters from the same key consecutively, a **pause (space)** is required.

Special characters:
- `*` : Backspace (removes the previously typed character)
- `0` : Space character
- `#` : End of input

---

## Keypad Mapping

| Key | Characters |
|-----|-----------|
| 1 | `& ' (` |
| 2 | `ABC` |
| 3 | `DEF` |
| 4 | `GHI` |
| 5 | `JKL` |
| 6 | `MNO` |
| 7 | `PQRS` |
| 8 | `TUV` |
| 9 | `WXYZ` |
| 0 | Space |

---

## Solution Approach

1. Iterate through the input string character by character.
2. Track the current number key and count how many times it is pressed consecutively.
3. When a pause (` `), special character, or new number is encountered:
   - Convert the previous key and press count into a character.
   - Append the character to the result.
4. Use modulo arithmetic to cycle through characters safely:

   ```csharp
	index = (count - 1) % letters.Length;
   ```

How to Run
---
Clone the repository:
```
git clone https://github.com/PhilipHousdens/IronSoftwareCodingChallenge.git
```

Open the project in Visual Studio or VS Code.

---
## Test Coverage
Unit tests are implemented using xUnit in a dedicated test project:

```
IronSoftwareCodingChallenge.Tests/
```
### Test Results

All tests pass successfully:

```
Total tests: 10
Passed: 10
Failed: 0
Skipped: 0
```
Run tests with:

```
dotnet test IronSoftwareCodingChallenge.Tests/IronSoftwareCodingChallenge.Tests.csproj
```


## Runner
A console runner project is included to demonstrate usage:

```
IronSoftwareCodingChallenge.Runner
```
Run it with: 
```
dotnet run --project IronSoftwareCodingChallenge.Runner
```
Sample Output:
```
Input: 33# => Output: E
Input: 227*# => Output: B
Input: 4433555 555666# => Output: HELLO
Input: 8 88777444666*664# => Output: TURING
```