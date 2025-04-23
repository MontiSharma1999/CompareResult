# 🕒 String Comparison Timestamp Demo

This is a simple .NET Core console application that demonstrates and compares the execution time of different string comparison methods in C#. It logs timestamps using `Stopwatch` to show how long each method takes.

---

## 🔍 Comparison Methods

The following string comparison techniques are used:

1. **ToLower + `==` Operator**  
   Compares two strings in a case-insensitive way by converting both to lowercase.
   ```csharp
   str1.ToLower() == str2.ToLower()
   str1.Equals(str2)
   string.Compare(str1, str2, true)

/CompareResult
│
├── Program.cs
├── README.md
└── .gitignore

---

## 📤 Sample Output

String Comparison Performance:

ToLower == Comparison took:   00:00:00.0000123
Equals() Comparison took:     00:00:00.0000021
Compare() Comparison took:    00:00:00.0000034
