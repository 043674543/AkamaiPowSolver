# Akamai Anti-Bot Proof of Work Solver

This C# project contains a proof of work solver for the Akamai Anti-Bot system. It computes the required proof of work (PoW) values based on the given parameters.

**Important Note:** This code has not been extensively tested and may contain bugs. If you encounter any issues or bugs, please report them, and I'll work on fixing them.

## Usage

To use the solver, create an instance of the `Solver` class with the following parameters:

- `sec`: The security code string.

- `timestamp`: The timestamp value.

- `nonce`: The nonce string.

- `difficulty`: The initial difficulty level.

Then, call the `ComputePoW()` method to generate a list of 10 valid proof of work values.

## Other Languages

You can find implementations of the solver in other programming languages in the `OtherLangs` folder:

- JavaScript: `OtherLangs/JS/Solver.js`

- Go: `OtherLangs/GoLang/Solver.go`

Please note that these implementations are not written or checked by me, so if you encounter any issues, please report them.

## Contributions

If you would like to contribute to this project by implementing the same logic in another programming language, please open a pull request (PR), and I'll be happy to review and merge your changes.
