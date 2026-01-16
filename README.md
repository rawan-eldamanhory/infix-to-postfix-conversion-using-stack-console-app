# Infix to Postfix Conversion Using Stack (C#)

This project demonstrates how to convert an **infix expression** into a **postfix expression** using a **stack** in C#.

## What is Infix & Postfix?
- **Infix**: Operator between operands  
  Example: `(3+2)+7/2*((7+3)*2)`
- **Postfix**: Operator after operands  
  Example: `32+72/73+2**+`

## Algorithm Used
1. Scan the infix expression from left to right
2. Operands are added directly to output
3. Operators are pushed to stack based on precedence
4. Parentheses control evaluation order
5. Remaining operators are popped from stack

## Supported Operators
- `+`, `-`
- `*`, `/`
- `^`
- Parentheses `(` `)`

## Limitations
- Operands must be single characters (digits or letters)

## Concepts Used
- Stack (LIFO)
- Expression parsing
- Operator precedence
- StringBuilder
- Exception handling

## Sample Output
Postfix Expression: 32+72/73+2**++

## Technology
- C#
- Console Application
- Visual Studio
  
## How to Run
1. Open project in Visual Studio
2. Run the console application
