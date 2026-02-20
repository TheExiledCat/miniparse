# Assignment: Expression Language Interpreter (C#)

## Goal

Implement a small expression language using: - Recursive descent
parsing - Abstract Syntax Tree (AST) - Visitor pattern

The program evaluates a sequence of expressions.\
The value of the **last expression** is the program result.

---

## Language Features

### Supported Expressions

```
a = 10
b = a * 2
a + b
(a + b) * 5
```

### Rules

- Assignment is an expression
- Variables persist across expressions
- Arithmetic operators:
  - `+ - * /`
- Parentheses are supported
- Identifiers consist of letters only
- All values are integers
- Print the expressions value after every expression being written


**Note:** Assignment is right-associative.


---

## Visitors to Implement

### 1. Evaluation Visitor (ScriptContext)

- Stores variables in a dictionary
- Evaluates expressions recursively
- Assignment returns assigned value

### 2. Pretty Print Visitor

Outputs normalized representation of the expression tree. (prefix notation)

Example:

```
a = 10  -> (= a 10)
a + b * 2 -> (+ a (* b 2))
```

### 3. Validation Visitor

Detects: - Use of undefined variables - Division by zero when divisor is
a literal

---

## Example Input

```
a = 10
b = a * 3
a + c
```

### Expected Result

```
error: use of undefined variable 'c'
```

### 4. Expression Simplifier

Optimizes ASTs into smaller ASTs where possible

## Example Input

```
a = 10 + 5 
-> constant(10) + constant(5) 

normalized to: constant(15)

(10 + 5) * a 
-> constant(10) + (constant(5) * var(a)) 
normalized to: constant(15) * var(a)
```
---

## Optional Extensions

- Unary minus support (negative numbers)
- Constant folding visitor
- Expression depth calculator
- Immutable AST rewrite visitor

---

## Evaluation Criteria

- Correct parsing and operator precedence
- Clean recursive structure
- Proper separation of AST and behavior
- Clear and extensible design
- Robust error handling