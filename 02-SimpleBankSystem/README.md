# Simple Bank System (Console Application)

A basic console-based banking system written in C# for practicing OOP principles and user input handling.

Took around 2 hours to make without AI

## Features

- Account creation with username
- Balance viewing
- Deposit functionality
- Withdrawal functionality with balance checks
- Simple menu-driven interface
- Basic input validation

## How to Use

1. Clone the repository
2. Open the solution in Visual Studio (or your preferred C# IDE)
3. Build and run the program
4. Follow the on-screen instructions:
   - Enter your name to create an account
   - Select an operation from the menu
   - View or modify your account balance
   - Continue or exit the application

## Code Structure

- `Bank.cs`: Contains the core bank account data model
- `Operations.cs`: Handles banking operations (deposit/withdraw/balance)
- `Menu.cs`: Manages user interaction and flow
- `Program.cs`: Main entry point

## Technical Details

This project demonstrates:
- Object-oriented programming principles
- Class relationships (Bank → Operations → Menu)
- Basic input validation
- State management through objects
- Simple console UI flow

## Limitations (By Design)

This is a learning exercise with intentional simplifications:
- No persistent storage (resets when program closes)
- No password/authentication
- Basic error handling
- Console-only interface

## Potential Enhancements

Future improvements could include:
- Database integration for persistence
- Multiple account support
- Transaction history
- Enhanced security features
- Proper currency handling
