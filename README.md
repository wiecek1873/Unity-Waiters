# Unity-Waiters
Static pool with coroutine waiters.

## Pros
No garbage collection.

No more cached WaitForSeconds.

## Installation
Paste Waiters.cs file into your Unity Project

## Usage
```cs
  //Your code
  
  float _waitTime = 2f;
  yield return Waiters.WaitForSeconds(_waitTime);
```
